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
