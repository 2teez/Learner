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

# using retry option
def math_divide_with_input(num)
  print "Err practice....\n"
  begin
    deno = gets.chomp.to_i
    result = num/deno
  rescue Exception => ex
    puts ex.class
    puts ex.to_s
    print "Use a valid input to divide #{num}: "
    retry
  end
  return result
end

puts math_divide_with_input 4
