#!/usr/bin/env ruby

def get_input(msg)
  print "#{msg} "
  gets.chomp
end

filename = get_input "Enter a filename: "
# check if the file exists
while !File.exist?(filename) do
  puts "Invalid filename #{filename}"
  filename = get_input("Enter a valid filename: ")
end

file = File.open(filename, "r")

freq_words = Hash.new

file.each do |line|
  words = line.chomp.split(" ")
   words.each { |word|
     if freq_words.has_key?(word)
       freq_words[word] += 1
     else
        freq_words[word] =1
     end
   }
end

p freq_words.sort {
  |a, b| a <=> b
}

file.readlines.each {|line|
    line.chomp.scan(/\w+/).each {|word|
      if freq_words.has_key?(word)
        freq_words[word] += 1
      else
         freq_words[word] =1
      end
    }
}

p freq_words.sort {
  |a, b| a[1] <=> b[1]
}

file.close()
