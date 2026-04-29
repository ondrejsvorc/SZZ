import os
from typing import List, Optional

TARGET_FILENAME = "README.md"
OUTPUT_INDEX_FILE = "index.md"
TITLE_HEADER = "## SZZ"
DESCRIPTION = "Automaticky generovaný seznam materiálů z repozitáře."
QUESTION_LABEL = "Otázka"
IGNORE_PREFIX = "."

def is_hidden(path: str) -> bool:
    return os.path.basename(path).startswith(IGNORE_PREFIX)

def format_url_path(root: str, filename: str) -> str:
    relative_path = os.path.relpath(os.path.join(root, filename), ".")
    return relative_path.replace(" ", "%20")

def get_chapter_display_name(root: str) -> str:
    current_folder = os.path.basename(root)
    
    if not current_folder.isdigit():
        return current_folder

    parent_folder = os.path.basename(os.path.dirname(root))
    return f"{parent_folder} - {QUESTION_LABEL} {current_folder}"

def create_markdown_line(name: str, url: str) -> str:
    return f"- [{name}]({url})"

def build_index_content(links: List[str]) -> str:
    header = f"{TITLE_HEADER}\n\n{DESCRIPTION}\n\n"
    return header + "\n".join(links) + "\n"

def scan_for_markdown_links() -> List[str]:
    markdown_links = []

    for root, dirs, files in sorted(os.walk(".")):
        dirs[:] = [d for d in dirs if not is_hidden(d)]

        if root == ".":
            continue

        if TARGET_FILENAME not in files:
            continue

        display_name = get_chapter_display_name(root)
        url = format_url_path(root, TARGET_FILENAME)
        
        link_line = create_markdown_line(display_name, url)
        markdown_links.append(link_line)

    return markdown_links

def generate_index() -> None:
    links = scan_for_markdown_links()
    
    if not links:
        print("No content found for generation.")
        return

    content = build_index_content(links)

    with open(OUTPUT_INDEX_FILE, "w", encoding="utf-8") as f:
        f.write(content)

if __name__ == "__main__":
    generate_index()