#!/usr/bin/env ruby

module Attributes
  def speak
    raise NotImplementedError
  end
end

Animal = Struct.new(:name, :age)
dog = Animal.new('Mavin', 23)
dog.extend(Attributes)

class << dog
  def speak
    puts "woof " * 2
  end
end

puts dog, dog.speak

class Human < Animal
  def initialize(firstname, lastname, age)
    super(firstname, age)
    @firstname = firstname
    @lastname = lastname
    @age = age
  end
  def speak
    puts 'speaking...'
  end
  def to_s
    "#{self.class}: #{@firstname}, #{@lastname}, Age: #{@age}"
  end
end

java = Human.new('james', 'gosling', 23)
puts java, java.speak

class Cat < Animal
  include Attributes
  def speak
    puts "meow.."
  end
end

lion = Cat.new('cat', 23)
puts lion, lion.speak
