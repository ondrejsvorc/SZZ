#!/bin/bash

if [ "$#" -lt 3 ]; then
    echo "Usage: $0 <directory> <output.csv> <extensions...>"
    exit 1
fi

input_directory="$1"
output_csv_file="$2"

shift 2

echo "path" > "$output_csv_file"

for file_extension in "$@"; do
    find "$input_directory" -type f -iname "*.$file_extension" >> "$output_csv_file"
done

# V terminálu pak:
# chmod +x hledej
# sudo mv hledej /usr/local/bin/
# hledej /adresar_s_obrazky /vystupni_soubor.csv bmp png jpg