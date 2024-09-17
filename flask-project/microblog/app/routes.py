from flask import render_template
from app import app

@app.route('/')
@app.route('/index')
@app.route('/index2')
@app.route('/index3')
def index():
    user = {'username': 'timothy'}
    posts = [
        {'author': {'username': 'Kunle'},
            'post': 'Scotland is cool and beautiful!'},
        {'author': {'username':'Tunde'},
            'post': 'The movie `The Killer` is Intresting.'},
    ]
    return render_template("index3.html", title="Home", user=user, posts=posts)
