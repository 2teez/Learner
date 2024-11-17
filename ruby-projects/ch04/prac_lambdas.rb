#!/usr/bin/env ruby

def cap(args)
  yield (args)
end

words = ['hello', 'good day', 'how do you do']
puts words.collect {|x|
   cap(x) {|s| s.capitalize!}
}

capL = lambda {|x| x.capitalize!}
p capL.call 'omit'

def multiply(num)
  return proc{|x| num * x}
end

puts multiply(21).call(5)
