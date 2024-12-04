<?php

define("TIRE_PRICE", 100);
define("OIL_PRICE", 10);
define("SPARK_PLUG_PRICE", 4);

$document_root = $_SERVER["DOCUMENT_ROOT"];

$output = "";
if (
    !isset($_POST["tires"]) &&
    !isset($_POST["oil"]) &&
    !isset($_POST["plugs"]) &&
    !isset($_POST["address"])
) {
    include __DIR__ . "/../ch00/order_form.php";
} else {
    $tires = htmlspecialchars($_POST["tires"]);
    $oil = htmlspecialchars($_POST["oil"]);
    $plugs = htmlspecialchars($_POST["plugs"]);
    $address = htmlspecialchars($_POST["address"]);
    $total = (int) $tires + (int) $oil + (int) $plugs;
    $output .=
        $total .
        "<br/>" .
        $tires .
        " tires <br/>" .
        $oil .
        " bottles of oil <br/>" .
        $plugs .
        " spark plugs <br/>";
    $subtotal =
        (int) $tires * TIRE_PRICE +
        (int) $oil * OIL_PRICE +
        (int) $plugs * SPARK_PLUG_PRICE;
    $totalamt = $subtotal + (1 + $subtotal * 0.1);
    $output .= "Subtotal: $" . number_format($subtotal, 2) . "<br/>";
    $output .= "Total including tax: $" . number_format($totalamt, 2) . "<br>";
    $output .= "Address to ship to is " . $address . "<br/>";

    include __DIR__ . "/../ch00/processed_order.html.php";
}
