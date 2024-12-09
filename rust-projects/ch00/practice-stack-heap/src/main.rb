#!/usr/bin/env ruby

module UtilExt
  def splitter
    if self.include?("\s")
      return self.split
    end
    self
  end
  def first
    splitter.first
  end
  def last
    splitter.last
  end
  private :splitter
end

include UtilExt

String.include(UtilExt)
puts "hello world".first
puts "hello world".last
