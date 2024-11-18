#!/usr/bin/env ruby

module Attributes
  def speak
    puts "talking"
  end
  public module_function :speak
end

class Person
  attr_accessor :name, :age
  def to_s
    "Person{Name: #{@name}, Age: #{@age}}"
  end
end

class Human < Person
  include Attributes
  class << self
    def say
      puts "I am human"
    end
  end
end

p = Human.new
p.speak
Attributes.speak
p.name = 'Java'
p.age = 34
puts p.to_s

module Aqua
  HANDFINS = 8
  def swim
    puts "Swimming.."
    puts "#{HANDFINS}"
  end
end

class << p
    def programmer
      puts "I am a programmer"
    end
end

p.extend(Aqua)
p.swim
Human.say
p.programmer

pp = Human.new
#pp.programmer

class Person
  def ruby_programmer
    puts self.class.to_s << ' programming in ruby'
  end
end

pp.ruby_programmer
p.ruby_programmer
