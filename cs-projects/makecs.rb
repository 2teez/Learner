#!/usr/bin/env ruby

def get_help()
  if ARGV.size != 2 then
    puts "./#{$0} [options] [filename]"
    exit
  end
end

get_help()

if ARGV[0] == "create"
  filename = "#{ARGV[1]}"
  Dir.new(".").each do |file|
    if file == filename
      puts "#{filename} project exits."
      exit
    end
  end
  `dotnet new console -n #{filename}`
elsif ARGV[0] == "clean"
  `rm -rf #{filename}`
else
  puts "#{ARGV[0]} can either be `create` or `clean`"
end

if __FILE__ == $0 then
  #require "minitest";
  require "minitest/autorun";

  class Tester < Minitest::Test
    def setup
    end
  end
end
