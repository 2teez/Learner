#!/usr/bin/env ruby

require 'minitest'
require 'minitest/autorun'
require_relative '../text_analyzer'
require_relative '../../ios'

class AnalyzerTest < Minitest::Test

  @@ana = Text::Analyzer.new
  def setup
    @ana = @@ana
  end

  def test_property_data
    skip
    expected = @ana.data
    assert_equal expected, []
  end

  def test_fn_count_chars
    expected = @ana.chars
    assert_equal expected, 50
  end

  def test_fn_count_chars_only
    expected = @ana.chars_only
    assert_equal expected, 38
  end

  def test_fn_line_count
    expected = @ana.lines
    assert_equal expected, 3
  end

  def test_fn_word_count
    expected = @ana.words
    assert_equal expected, 8
  end
end
