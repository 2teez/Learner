#!/usr/bin/env ruby

def get_input(msg)
  print "#{msg}"
  gets.chomp
end

# get filename
filename = get_input("Enter filename: ")
# check if the filename exist
until File.exist?(filename) do
  puts "Invalid filename #{filename}."
  filename = get_input("Enter a valid filename: ")
end

#use IO to read the file
# using foreach or readlines
IO.foreach(filename){|line|
    puts line
}

# use File which is a subclass for IO
File.open(filename, "r").each{|line| puts line}
