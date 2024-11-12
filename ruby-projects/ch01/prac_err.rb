#!/usr/bin/env ruby

print "Enter a divisor- "
divisor = gets.chomp.to_i

begin
  result = 5/divisor
rescue TypeError => oex
  puts (oex.class)
  puts (oex.to_s)
  result = 0
rescue Exception => ex
  puts (ex.class)
  puts(ex.to_s)
  result = 0
end

def math_divide(num = 1, denum = 1,
  msg = "#{num}/#{denum}")
  print msg << ' = '
  result = num/denum
  rescue Exception => ex
    puts ex.class
    puts ex.to_s
    return result
end

puts math_divide
puts math_divide(5, 0)
puts math_divide(6, 2)
