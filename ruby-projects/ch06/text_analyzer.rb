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
      @data = FileReader.new.read ||= []
    end
    def chars
      @data.chars.length
    end
    def chars_only
      @data.chars.select{|char| char.match(/[a-zA-Z0-9]/)}.length
    end
    def lines
      @data.length
    end
    def words
      @data.map {|line| line.chomp.split(/\s+?/)}.reduce(0){|a, arr| a+=arr.size}
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
