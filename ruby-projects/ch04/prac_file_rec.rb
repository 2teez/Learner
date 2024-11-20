#!/usr/bin/env ruby

require_relative '../ios'

def print_files(path, depth = 1)
  Dir.foreach(path) do |file|
    next if file == '.' || file == '..' # Skip current and parent directory references

    full_path = File.join(path, file)
    if File.directory?(full_path)
      puts "#{'-' * depth} [DIR] #{file}"
      print_files(full_path, depth + 1) # Recurse into subdirectory
    else
      puts "#{'-' * depth} #{file}" # Print file name
    end
  end
end

# Uncomment the following line to use your `IOS` module for filename input
filename = IOS.get_filename "Enter a directory path: "
print_files(filename)
