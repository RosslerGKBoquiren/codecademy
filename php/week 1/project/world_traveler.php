<?php
// create variables to hold the amount of each foreign currency
$riel = 2103942;
$kyat = 19092;
$krones = 109;
$lek = 9094;  
// print how much of each currency we started out with
echo $riel;
echo "\n" . $kyat;
echo "\n" . $krones;
echo "\n" . $lek;
// exchange rate for each currencies
$riel_to_cad = 0.00033;
$kyat_to_cad = 0.00064;
$krones_to_cad = 0.20;
$lek_to_cad = 0.014;
// calculate the amount of USD it will be exchanged for 
$cad_riel = $riel * $riel_to_cad;
$cad_kyat = $kyat * $kyat_to_cad;
$cad_krones = $krones * $krones_to_cad;
$cad_lek = $lek * $lek_to_cad;
echo "\n" . "The amount of CAD Riel will be exchanged for is ${cad_riel}";
echo "\n" . "The amount of CAD Kyat will be exchanged for is ${cad_kyat}";
echo "\n" . "The amount of CAD Krones will be exchanged for is ${cad_krones}";
echo "\n" . "The amount of CAD Lek will be exchanged for is ${cad_lek}";
// currency exchange business takes a flat 1$ fee per conversion. Calculate the final amount
$cad_riel--;
$cad_kyat--;
$cad_krones--;
$cad_lek--;
echo "\n" . "The final amount of CAD Riel will be exchanged for is ${cad_riel} after fees";
echo "\n" . "The final amount of CAD Kyat will be exchanged for is ${cad_kyat} after fees";
echo "\n" . "The final amount of CAD Krones will be exchanged for is ${cad_krones} after fees";
echo "\n" . "The final amount of CAD Lek will be exchanged for is ${cad_lek} after fees";