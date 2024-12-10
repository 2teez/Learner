#!/usr/bin/env ruby

module ActualSize
  def len
    self.length-1
  end
end
module UtilExt
  def splitter(delimiter)
    return nil if self.nil?
    include?(delimiter) ? split(delimiter) : self
  end
  def first(delimiter="\s")
    result = splitter(delimiter)
    result.is_a?(Array) ? result.first : self
  end
  def last(delimiter="\s")
    result = splitter(delimiter)
    result.is_a?(Array) ? result.last : self
  end
  private :splitter
end

if __FILE__ == $0 then
  require 'minitest'
  require 'minitest/autorun'

  class Test < Minitest::Test

    def setup
      String.include(UtilExt)
      Array.include(ActualSize)
      @data = ['hello world', 'howdy', 'hi-there', '', 'hew there rusty']
    end
    def test_first_word
      assert_equal 'hello there'.first, 'hello', "tested hello there against hello"
    end
    def test_first_words
      first_words = ['hello', 'howdy', 'hi-there', '', 'hew']
      (0..@data.len).to_a.each do |index|
        assert_equal @data[index].first, first_words[index]
      end
    end
    def test_last_word
      assert_equal 'hello=there'.last('='), 'there', "tested hello there against hello"
    end
    def test_last_words
      first_words = %w/world howdy hi-there '' rusty/
      (0..@data.len).to_a.each do |index|
        assert_equal @data[index].last, first_words[index]
      end
    end
  end
end
