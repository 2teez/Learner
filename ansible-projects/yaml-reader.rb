#!/usr/bin/env ruby

require 'yaml'

def usage
  case
    when ARGV.empty? then
      puts "Usage: #{$0} <yaml file to read>"
      exit
    when ARGV[0] !~ /.yml$/ then
      puts ("Use only yaml file")
      exit
  end
end

usage # check if files used

file = ARGV[0]

File.open(file) {|f|
  YAML.load_stream(f) {|doc|
    p doc
  }
}
