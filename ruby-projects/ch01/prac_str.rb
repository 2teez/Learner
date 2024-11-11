#!/usr/bin/env ruby

i = 0
begin
  s = "[" << i << ":" << i.to_s << "]"
  p s
  puts s
  i += 1
end until i == 256

named = 'java'
puts "#{named} has object id of #{named.object_id}"
#named[0] = 'J'
#puts "#{named} has object id of #{named.object_id}"
named = named + "!"
puts "#{named} has object id of #{named.object_id}"
named.capitalize!
puts "#{named} has object id of #{named.object_id}"

class String
    def count
       return self.length
    end
end

p named.count
 p ('a'..'z').to_a
