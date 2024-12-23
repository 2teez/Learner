#!/usr/bin/env ruby

def get_help()
  if ARGV.size != 2 then
    puts "./#{$0} [options] [filename]"
    exit
  end
end

get_help()

if ARGV[0] == "create"
  `dotnet new console -n #{ARGV[1]}`
elsif ARGV[0] == "clean"
  `rm -rf #{ARGV[1]}/bin/`
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
