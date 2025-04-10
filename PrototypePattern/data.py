import os

def find_files_with_extension(extension, base_path='.'):
    matched_files = []
    for root, _, files in os.walk(base_path):
        for file in files:
            if file.endswith(f".{extension}"):
                full_path = os.path.join(root, file)
                rel_path = os.path.relpath(full_path, base_path)
                matched_files.append((file, rel_path, full_path))
    return matched_files

def write_file_details_to_text(files, output_filename='output.txt'):
    with open(output_filename, 'w', encoding='utf-8') as output_file:
        for filename, rel_path, full_path in files:
            output_file.write(f"{filename}\n")
            output_file.write(f"{rel_path}\n")
            try:
                with open(full_path, 'r', encoding='utf-8') as f:
                    content = f.read()
            except Exception as e:
                content = f"Error reading file: {e}"
            output_file.write(f"{content}\n")
            output_file.write("\n" + "-" * 30 + "\n\n")

def main():
    extension = input("Enter the file extension (e.g., cs, java, py): ").strip()
    base_path = os.getcwd()
    matched_files = find_files_with_extension(extension, base_path)

    if matched_files:
        print(f"Found {len(matched_files)} .{extension} file(s). Writing to output.txt...")
        write_file_details_to_text(matched_files)
        print("Done!")
    else:
        print(f"No .{extension} files found in {base_path}.")

if __name__ == "__main__":
    main()
