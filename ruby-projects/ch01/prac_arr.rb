#!/usr/bin/env ruby

numbers = (1..50).to_a
class Integer
    def is_even?
      if 0 == self % 2 then return true end
    end

    def is_odd?
      return !self.is_even?
    end

    def is_prime?
        if self < 2 then return false end
        for num in (2..(self -1)) do
            if 0 == self % num then
              return false
            end
        end
        return true
    end
end

=begin
for num in (1..10) do
    p "#{num}, #{num.is_prime?}"
end
=end

prime_nums = numbers.filter {|num| num.is_prime?}
odd_nums = numbers.filter{|num| num.is_odd?}
p prime_nums, odd_nums
p prime_nums & odd_nums
p odd_nums - prime_nums
p (odd_nums + prime_nums).sort!

names = ['gosling', 'stroup']
names << 'larry'
p names

# hash or map
class Pair
  include Comparable
  attr_reader :first, :second

  def initialize(afirst, asecond)
    @first = afirst
    @second = asecond
  end

  def to_s # overwrite the default
    "Pair[first: #{first}, second: #{second}]"
  end

end

hash = Hash.new
p hash

ahash = {}; p ahash
ahash = {:gosling => 'java', :stroup => 'c++', :larry => 'perl'}; p ahash
p ahash.keys

first_pair = Pair.new(1, 'java')
second_pair = Pair.new(2, 'clojure')

p first_pair, second_pair, first_pair.second <=> second_pair.second
p first_pair.to_s
for lang, author in (ahash.invert.sort {|a, b|
  a = Pair.new(a[0], a[1])
  b = Pair.new(b[0], b[1])
  a.first <=> b.first}) do
  puts "#{author} made #{lang}"
  end
