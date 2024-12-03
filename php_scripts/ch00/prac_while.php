<!DOCTYPE html>
    <html lang="en">
    <meta charset="utf-8">
        <head>
          <title>While Loop Practice In Php</title>
	    <style>
            body {
                max-width: 800px;
                margin: 0 auto;
          		padding: 0;
            }

            table {
                width: 85%;
                border: 4px solid black;
                border-radius: 0 0 35px 35px;
            }

            thead {
                font-family: Ariel, Helvetica, sans-serif;
                font-size: 3.75em;
                color: rgba(255, 255, 255, 0.9);
                text-align: center;
                background-color: #ccc;
                padding: 0 45px 10px 45px;
                text-shadow: -4px 5px 1px rgba(100, 0, 0, 0.8);
            }
            tbody {
                font-family: Helvetica, sans-serif;
                font-size: 1.8em;
                text-align: center;
                line-height: 1.2em;
            }

	    </style>
            <!--script src=></script-->
        </head>
        <body>
            <p class="main">
		<table>
		<thead>
		    <td>Distance</td>
		    <td>Cost</td>
		</thead>
		<tbody>
			<?php
   $distance = 50;
   while ($distance <= 250) {
       echo "<tr><td>" .
           $distance .
           '</td>
		  				<td>' .
           $distance / 10 .
           "</td></tr>";
       $distance += 50;
   }
   ?>
		</tbody>
		</table>
            </p>
        </body>
    </html>
