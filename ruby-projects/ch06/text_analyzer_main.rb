#!/usr/bin/env ruby
require_relative 'text_analyzer'
ana = Text::Analyzer.new
p ana.data
p %W/hello world in time/.chars
