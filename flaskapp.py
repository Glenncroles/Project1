from flask import Flask
app = Flask(__name__)

@app.route('/')
def hello_world():
  return random.randint(1,100000001)

if __name__ == '__main__':
  app.run()
