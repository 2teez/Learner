#!/usr/bin/env ruby
require_relative '../ios'

class Array
  def chars
      self.join.split(//)
  end
end

module Text

  class Analyzer
    attr_reader :data
    def initialize
      @data = FileReader.new.read ||= []
    end
    def chars
      @data.chars.length
    end
  end

  private
  class FileReader
    def initialize
      @file = IOS.get_filename("Enter a filename: ")
    end
    def read
      File.foreach(@file).collect{|line| line}
    end
  end
end

if __FILE__ == $0
  require 'minitest'
  require 'minitest/autorun'

  class AnalyzerTest < Minitest::Test
    def setup
      @ana = Text::Analyzer.new
    end
    def test_property_data
      #skip
      expected = @ana.data
      assert_equal expected, []
    end
    def test_fn_count_chars
      expected = @ana.chars
      assert_equal expected, 26
    end
    def test_fn_count_chars_only
      expected = @ana.chars_only
      assert_equal expected, 22
    end
  end
end
