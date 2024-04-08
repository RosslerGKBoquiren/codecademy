<?php
$initial = '555';

$a = octdec($initial); // convert this octal string to a decimal number.

$b = deg2rad($a); // convert degrees to radians

$c = cos($b); // convert to cosine

$d = round($c, 3); // convert to round with 3 decimal places

$e = log($d); // natural log of $d

$f = abs($e); // absolute value $e

$g = acos($f); // inverse or arc cosine $f

$h = rad2deg($g); // radians to degrees

$i = floor($h); // to floor (round down) $h

$j = $i - 47;

echo $j; // 42
