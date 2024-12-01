#!/usr/bin/env ruby

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


include Exts

name = false
p name.or('java').or('perl')
number = 21
p number.or(44).or(32)
p 3.145.to_s.or(3)

if __FILE__ == $0 then
    require 'minitest'
    require 'minitest/autorun'


    class Tester < Minitest::Test
      include Exts
      def setup
        Object.include(Exts)
      end
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
