#!/usr/bin/env ruby

d = Proc.new {|x, y, z| x = y * z; puts x }
d.call(4,8,2,7)

c = proc {|x, y, z| x = y * z; puts x }
c.call(4,8,2,7)

begin
b = lambda {|x, y, z| x = y * z; puts x }
b.call(4,8,2,7) # error cause of number of arugments
rescue => ex
  puts ex.class, ex.to_s
ensure
b.call(6,9,0)
end

def count_if(data)
  c = 0
  for d in data do
   if yield d then
     p d
     c+=1
   end
  end
  c
end

p (count_if((1..10).to_a) {|x| x % 2 == 0})
p (count_if(('a'..'z').to_a()[0..12]) {|x| x.match(/[aeiou]/)})

class User
  #attr_reader :username, :password, :password_condfirmation
 def initialize(username, pass='', pass_confirm='')
    @username = username
    @password = pass
    @pass_confirmation = pass_confirm
 end
 def [](key)
   hash = {username: @username, password: @password, pass_confirm: @pass_confirmation}
   return hash if hash.has_key?(key)
 end
 def to_s
   "User{username: #{@username}, password: #{@password}, password_confifm: #{@pass_confirmation}}"
 end
end

users = {
  admin: {username: 'admin', password: 'admin', password_confirmation: 'admin'},
  guest: {username: 'guest', password: 'guest', password_confirmation: ''},
  user: {username: 'user', password: '', password_confirmation: ''},
}

users.each { |_, value|
  p value if value[:password] == value[:password_confirmation]
}

auser = User.new('user', 'class-user', 'user')
p auser.to_s
p auser[:password], auser[:username]
