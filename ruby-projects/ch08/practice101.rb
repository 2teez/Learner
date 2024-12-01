#!/usr/bin/env ruby
require 'byebug'

module Exts
  def or(value) 
    case self
      when String
        if self != ''
          self
        elsif self == ''
          value
        else
          value
        end
      when NilClass
        value
    end
  end
end

#byebug

include Exts

name = false
      # yield a nil 
      # then using or the 
      # second time works as intended   
p name.or('java').or('perl')
number = 21
p number.or(44).or(32)
p 3.145.to_s.or(3)

if __FILE__ == $0 then
    require 'minitest'
    require 'minitest/autorun'


    class Tester < Minitest::Test
      include Exts            # not needed for a test
      def setup               # this also not needed
        Object.include(Exts)  # same as this
      end                     #
      def test_or_func_on_string
        assert_equal 'timothy'.or('tim'), 'timothy', "incorrect!"
      end
      def test_or_func_on_empty_string
        assert_equal ''.or('tim'), 'tim'
      end
      def test_or_func_on_nil_class
        assert_equal nil.or('tim'), 'tim'
      end

    end
end
