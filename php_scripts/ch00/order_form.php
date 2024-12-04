<!DOCTYPE html>
    <html lang="en">
    <meta charset="utf-8" />
        <head>
          <title>Order Form</title>
          <link
              href="http://fonts.googleapis.com/css?family=Varela+Round"
              rel="stylesheet"
          />
            <style>
                body {
                    background-color: rgb(120, 150, 200);
                    font-family: "Varela Round", Baskerville, serif;
                    font-size: 2.5em;
                    max-width: 800px;
                    margin:0 auto;
                    padding: 0;
                }

                table {
                    width: 100%;
                    //border: 4px solid black;
                    border-radius: 5px 5px 15px 15px;
                }

                thead {
                    background-color: rgb(120, 135, 144);
                    margin: 10px;
                }

                tbody {
                    font-family: "Varela Round", Baskerville, serif;
                    font-size: .7em;
                    line-height: 1.7em;
                    margin-left: 50px;
                    background-color: white;
                }
                td {
                    border-top: 2px solid black;
                    border-left: 2px solid black;
                    border-right: 2px solid black;
                    padding-left: 5px;
                    padding-botton: 10px;
                    border-radius: 0 0 15px 15px;
                }
              .btn {
                  font-family: "Palatino Linotype", Baskerville, serif;
                  font-size: 1em;
                  //border-top: 4px solid black;
                  padding-top: 10px;
                  padding-bottom: 15px;
                  background-color: black;
              }

              input[type="text"] {
                width: 200px; /* Makes the input longer */
                height: 18px; /* Makes the input taller */
                font-size: 18px; /* Increases the text size */
                padding: 10px; /* Adds space inside the input */
                border: 0px solid #007BFF;
                border-radius: 5px; /* Adds rounded corners */
                background-color: #f9f9f9; /* Light background */
                color: #333; /* Text color */
              }

              #address {
                  width: 300px; /* Makes the input longer */
              }

              input[type="submit"] {
                  width: 200px; /* Makes the input longer */
                  height: 45px; /* Makes the input taller */
                  font-size: 25px;
                  border-radius: 15px; /* Adds rounded corners */
              }
              input[type="submit"]:hover {
                 border-radius: 40px; /* Adds rounded corners */
                 font-family: Arial, Helvetica, sans-serif;
                 font-size: 1.2em;
                 color: red;
                 text-shadow: -4px 4px 2px rgba(0, 0, 0, 0.7);
              }
            </style>
            <!--script src=></script-->
        </head>
        <body>
            <div class="container">
                <form action="" method="post">
                <table>
                    <thead>
                        <td>Item</td>
                        <td>Quantity</td>
                    </thead>
                    <tbody>
                        <tr>
                            <td><label for="tires">Tires</label></td>
                            <td><input type="text" name="tires" id="tires"/></td>
                        </tr>
                        <tr>
                            <td><label for="oil">Oil</label></td>
                            <td><input type="text" name="oil" id="oil"/></td>
                        </tr>
                        <tr>
                            <td><label for="plugs">Spark Plugs</label></td>
                            <td><input type="text" name="plugs" id="plugs"/></td>
                        </tr>
                        <tr>
                            <td><label for="address">Shipping Address</label></td>
                            <td><input type="text" name="address" id="address"/></td>
                        </tr>
                        <tr class="btn" align="center">
                            <td class="btn" colspan="2">
                            <input type="submit" value="Submit"/>
                            </td>
                        </tr>
                    </tbody>
                </table>
                </form>
            </div>
        </body>
    </html>
