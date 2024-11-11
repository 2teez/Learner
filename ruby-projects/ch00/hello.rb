#!/usr/bin/env ruby

print "Hello, World of ruby!!\n"
puts "Hello, ruby"

print 'Enter your name: '
name = gets()
puts "My name is #{name}"

# test class and object in ruby
class Dog
  def get_name
    return @dog_name
  end

  def set_name(dog_name)
    @dog_name = dog_name
  end
end

f_dog = Dog.new
s_dog = Dog.new

puts f_dog, s_dog, f_dog.get_name, s_dog.get_name
f_dog.set_name "marvin"
s_dog.set_name "tiger"

puts f_dog.inspect, s_dog.inspect,
  f_dog.get_name, s_dog.get_name, f_dog.class

# check the main function
puts self, self.class

p s_dog
%x{bash cmd}
puts %x{pwd}
