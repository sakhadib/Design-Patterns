import os
import time

# List of folders to exclude from data collection
EXCLUDED_FOLDERS = {'.git', '.idea', '.vscode', 'bin', 'debug', 'obj', 'venv', 'build', 'node_modules', 'vendor'}

def collect_folder_data(path, level=0):
    """
    Traverse the folder structure and collect data about each folder and file.
    Arguments:
        path (str): The folder path to start the collection.
        level (int): The current depth level of the folder structure.
    Returns:
        str: A structured text containing folder and file data.
    """
    data = ""
    try:
        # List all files and directories in the given directory
        entries = os.listdir(path)

        # Loop through entries in the directory
        for entry in entries:
            full_path = os.path.join(path, entry)

            # Skip excluded folders
            if entry in EXCLUDED_FOLDERS:
                continue

            # If entry is a directory, recursively get data
            if os.path.isdir(full_path):
                data += f"<Folder Level={level} Name={entry} Path={full_path}>\n"
                # Check for README.md in the folder
                readme_path = os.path.join(full_path, 'README.md')
                if os.path.isfile(readme_path):
                    with open(readme_path, 'r', encoding='utf-8') as readme_file:
                        readme_content = readme_file.read()
                    data += f"<README Content={readme_content} Path={readme_path}>\n"
                    data += f"</README Content={readme_content} Path={readme_path}>\n"
                # Recurse deeper to collect data from subdirectories
                data += collect_folder_data(full_path, level + 1)
                data += f"</Folder Level={level} Name={entry} Path={full_path}>\n"
            
            # If entry is a file, collect file data
            elif os.path.isfile(full_path):
                file_size = os.path.getsize(full_path)
                file_extension = os.path.splitext(entry)[1]
                file_mod_time = time.ctime(os.path.getmtime(full_path))
                file_creation_time = time.ctime(os.path.getctime(full_path))
                data += f"<File Name={entry} Path={full_path} Size={file_size} Bytes Extension={file_extension} ModificationTime={file_mod_time} CreationTime={file_creation_time}>\n"
                data += f"</File Name={entry} Path={full_path} Size={file_size} Bytes Extension={file_extension} ModificationTime={file_mod_time} CreationTime={file_creation_time}>\n"
    
    except PermissionError:
        data += f"<Error Path={path}>Permission denied</Error>\n"
    
    return data

def save_data_to_file(folder_path, output_filename="FolderData.txt"):
    """
    Save the collected folder and file data to a text file.
    Arguments:
        folder_path (str): The path of the folder to collect data from.
        output_filename (str): The name of the output file to save the data.
    """
    collected_data = collect_folder_data(folder_path)
    
    with open(output_filename, 'w', encoding='utf-8') as file:
        file.write("<FolderData>\n")
        file.write(collected_data)
        file.write("</FolderData>\n")
    
    print(f"Data collection complete. Saved to {output_filename}")

# Example usage:
folder_path = r'F:\iut\5th_Sem_labs\DP_Final\DesignPatterns'  # Replace with your folder path
save_data_to_file(folder_path)
