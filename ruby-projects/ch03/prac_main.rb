#!/usr/bin/env ruby

require './string_palindrone'
require './integer_palindrone'

["Racecar", "madam I m adam", 12321, "nurse"].each do |word|
  puts "#{word} is Palindrone?: #{word.palindrone?}"
end
