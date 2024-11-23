#!/usr/bin/env ruby
require 'minitest'
require 'minitest/autorun'

class User
  attr_reader :name, :age
  def initialize(data={name:'John Doe', age:32})
    @name = data[:name]
    @age = data[:age]
  end
end

if __FILE__ == $0 then
  class UserTest < Minitest::Test
    def setup
      @user = User.new
    end

    def test_user_name
      #skip
      expected = 'John Doe'
      assert_equal expected, @user.name
    end

    def test_user_age
      #skip
      expected = 32
      assert_equal expected, @user.age
    end
  end
end
