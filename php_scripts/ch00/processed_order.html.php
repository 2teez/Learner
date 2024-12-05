<!DOCTYPE html>
    <html lang="en">
    <meta charset="utf-8" />
        <head>
          <title>Processed Order</title>
          <link
              href="http://fonts.googleapis.com/css?family=Varela+Round"
              rel="stylesheet"
          />
            <style>
              body {
                  background-color: rgb(120, 150, 200);
                  font-family: "Varela Round", Baskerville, sans-serif;
                  font-size: 1em;
                  max-width: 800px;
                  margin: 0 auto;
                  border-left: 4px solid white;
                  //border-bottom: 4px solid white;
                  border-right: 4px solid white;
                  border-radius: 45px 45px 45px 45px;
              }
              h1 {
                  font-family: "Arial Black", sans-serif;
                  font-size: 3.5em;
                  font-weight: normal;
                  text-align: center;
                  background-image: url("../../css-projects/images/bg_body.png") repeat-x;
                  text-shadow: -4px 4px 2px rgba(255, 255, 255, .6);
                  border-bottom: 4px solid black;
                  border-radius: 45px 45px 45px 45px;
                  margin: 0;
                  box-shadow: -4px 4px 3px rgba(255, 255, 255, .5);
              }
              h1 strong {
                  font-family: "Arial Black", sans-serif;
                  font-size: 2.5em;
                  color: #ffffff;
                  text-shadow: -4px 4px 3px rgba(0, 0, 0, .8);
                  line-height: 1em;
                  margin-right: -0.7em;
              }
              h2 {
                  font-family: "Varela Round", "Arial Black", serif;
                  font-size: 2.5em;
                  font-weight: normal;
                  padding-left: 50px;
                  margin-bottom: 0;
                  font-variant: small-caps;
                  //text-decoration: underline;
                  border-bottom: 2px solid black;
                  border-radius: 45px 45px 45px 45px;
                  box-shadow: -4px -4px 3px rgba(255, 255, 255, .5);
              }

              .main{
                  font-family: "Varela Round", Baskerville, sans-serif;
                  font-size: 1em;
                  line-height: 1.8em;
              }
              .ordered {
                  font-family: "Varela Round", Helvetica, sans-serif;
                  font-size: 1.2em;
                  line-height: 1.8em;
                  padding-left: 50px;
              }
              .footer {
                  border: 4px solid white;
                  padding-right: 50px;
                  border-radius: 0 0 45px 45px;
              }
            </style>
            <!--script src=></script-->
        </head>
        <body>
            <div>
                <h1><strong>Bob's</strong> Auto Parts</h1>
                <h2>Order Results</h2>
                <div class="main">
                    <div class="ordered">
                        <?php
                        echo "<p>Order Processed at " .
                            date("H:i:s j F Y") .
                            "</p>";
                        echo "<p>Your order is as follows: </p>
                        <p>Item ordered: " .
                            $output .
                            "</p>";
                        ?>
                    </div>
                    <div class="footer"></div>
                </div>
            </div>
        </body>
    </html>
