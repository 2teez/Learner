#!/usr/bin/env ruby

d = Proc.new {|x, y, z| x = y * z; puts x }
d.call(4,8,2,7)

c = proc {|x, y, z| x = y * z; puts x }
c.call(4,8,2,7)

begin
b = lambda {|x, y, z| x = y * z; puts x }
b.call(4,8,2,7) # error cause of number of arugments
rescue => ex
  puts ex.class, ex.to_s
ensure
b.call(6,9,0)
end

def count_if(data)
  for d in data do
    yield 0, d
    end
end

puts count_if((1..10).to_a) {|c, x| c += 1 if x % 2 == 0; c}
