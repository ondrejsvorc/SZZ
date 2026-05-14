import os
import re
from typing import Dict, List, Optional, Tuple
from urllib.parse import quote

TARGET_FILENAME = "README.md"
OUTPUT_INDEX_FILE = "index.md"
TITLE_HEADER = "## SZZ"
DESCRIPTION = "Automaticky generovaný seznam materiálů z repozitáře."
QUESTION_LABEL = "Otázka"
IGNORE_PREFIX = "."
SECTION_DIR_PATTERN = re.compile(r"^\d+ - .+")
FOLDER_NUMBER_PATTERN = re.compile(r"^(\d+)\s*-\s*(.+)$")


def natural_sort_key(value: str) -> List[object]:
    return [
        int(text) if text.isdigit() else text.lower()
        for text in re.split(r"(\d+)", value)
    ]


def format_url_path(root: str) -> str:
    relative_path = os.path.relpath(root, ".").replace(os.sep, "/")
    encoded_parts = [quote(part, safe="") for part in relative_path.split("/")]
    return "/".join(encoded_parts) + "/"


def read_readme_heading(readme_path: str) -> Optional[str]:
    try:
        with open(readme_path, encoding="utf-8") as handle:
            for line in handle:
                stripped = line.strip()
                if stripped.startswith("## "):
                    return stripped[3:].strip()
    except OSError:
        return None
    return None


def parse_folder_label(folder_name: str) -> Tuple[Optional[int], str]:
    numbered_match = FOLDER_NUMBER_PATTERN.match(folder_name)
    if numbered_match:
        return int(numbered_match.group(1)), numbered_match.group(2).strip()

    if folder_name.isdigit():
        number = int(folder_name)
        return number, f"{QUESTION_LABEL} {number}"

    return None, folder_name


def get_display_name(readme_dir: str) -> str:
    folder_name = os.path.basename(readme_dir)
    number, title = parse_folder_label(folder_name)
    heading = read_readme_heading(os.path.join(readme_dir, TARGET_FILENAME))

    if heading and not heading.isdigit():
        title = heading
    elif heading and heading.isdigit():
        number = int(heading)
        title = f"{QUESTION_LABEL} {number}"

    if number is not None:
        return f"{number:02d} – {title}"

    return title


def discover_sections() -> List[str]:
    sections = []
    for name in sorted(os.listdir("."), key=natural_sort_key):
        if name.startswith(IGNORE_PREFIX):
            continue
        path = os.path.join(".", name)
        if os.path.isdir(path) and SECTION_DIR_PATTERN.match(name):
            sections.append(name)
    return sections


def collect_section_links(section: str) -> List[Tuple[str, str]]:
    links: List[Tuple[str, str]] = []

    for root, dirs, files in os.walk(section):
        dirs[:] = sorted(
            [directory for directory in dirs if not directory.startswith(IGNORE_PREFIX)],
            key=natural_sort_key,
        )

        if TARGET_FILENAME not in files:
            continue

        if os.path.normpath(root) == os.path.normpath(section):
            continue

        links.append((get_display_name(root), format_url_path(root)))

    links.sort(key=lambda item: natural_sort_key(item[0]))
    return links


def build_index_content() -> str:
    sections = discover_sections()
    if not sections:
        return ""

    lines = [
        "---",
        "layout: default",
        "title: SZZ Rozcestník",
        "---",
        "",
        TITLE_HEADER,
        "",
        DESCRIPTION,
        "",
    ]

    for section in sections:
        links = collect_section_links(section)
        if not links:
            continue

        lines.append(f"## {section}")
        lines.append("")

        for display_name, url in links:
            lines.append(f"- [{display_name}]({url})")

        lines.append("")

    return "\n".join(lines).rstrip() + "\n"


def generate_index() -> None:
    content = build_index_content()
    if not content:
        print("No content found for generation.")
        return

    with open(OUTPUT_INDEX_FILE, "w", encoding="utf-8") as handle:
        handle.write(content)


if __name__ == "__main__":
    generate_index()
