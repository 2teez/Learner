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

 # practice
 # array in ruby

 arr = Array.new
 p arr

 arr = [(1..3).to_a, [4,5,6,7], [8, 9, 10]]
p arr

for a in arr do
  p a
end

arr.each do |a|
   p a
end

p arr.sort {
  |a, b| a <=> a
}

p [4,9,2] <=> [4,9,2]

names = ['java', 'clojure', 'ruby', 'c++', 'c', nil,
  'javascript', 'perl', 'rust', 'zig-lang']
p names.sort {|a, b| a.to_s <=> b.to_s}
       .filter {|lang| lang != nil}
       .each {|lang| lang.to_s.capitalize!}
