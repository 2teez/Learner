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
end

p = Human.new
p.speak
Attributes.speak
p.name = 'Java'
p.age = 34
puts p.to_s
