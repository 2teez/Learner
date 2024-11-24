#!/usr/bin/env ruby
require_relative '../ios'

module ArrayExtensions
  def chars
      self.join.chars
  end
end

Array.include(ArrayExtensions)

module Text

  class Analyzer
    attr_reader :data
    def initialize
      @data     = FileReader.new.read
      @filename, @content  = @data[:filename], @data[:content]
    end
    def chars
      @content.chars.length
    end
    def chars_only
      @content.chars.select{|char| char.match(/[a-zA-Z0-9]/)}.length
    end
    def lines
      @content.length
    end
    def words
      @content.map {|line| line.chomp.split(/\s+?/)}.reduce(0){|a, arr| a+=arr.size}
    end
    def sentence
      @content.each{|line| line.chomp}.select{|line| line.match(/[.?!]/)}.count
    end

    def to_s
      <<~"EOF"
        STATISTICS FOR FILE: #{@filename} is as follows:
        Character Count:                    #{chars}
        Character Count (excluding spaces): #{chars_only}
        Line Count:                         #{lines}
        Word Count:                         #{words}
        Sentence Count:                     #{sentence}
      EOF
    end
  end

  private
  class FileReader
    def initialize
      @file = IOS.get_filename("Enter a filename: ")
    end
    def read
      {filename: @file, content: File.foreach(@file).to_a}
    end
  end
end
