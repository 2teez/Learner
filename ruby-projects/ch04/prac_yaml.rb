#!/usr/bin/env ruby

require 'yaml'

puts [{name: 'java', year: 1995, author: 'gosling'},
  {name: 'c++', year: 1981, author: 'stroup'},
  {name: 'perl', year: 1990, author: 'larry'}].to_yaml

class Langs
  def initialize(info={name: 'c', year: 1945, author: 'richeie'})
    @name = info[:name]
    @year = info[:year]
    @author = info[:author]
  end

  def to_s
    "#{self.class}[Name: #{@name.upcase}, Year: #{@year}, Author: #{@author.capitalize!}]"
  end
end

cpp = Langs.new {}

File.open('dumper.yml', 'w') {|f|
  YAML.dump(cpp.to_s, f)
}
#file.close
# read back
File.open('dumper.yml', 'r') {|f|
  $dumper = YAML.load(f)
}
p $dumper
