<?php
  
$annualExpenses = [
    "vacations" => 1000,
    "carRepairs" => 1000,    
];

$monthlyExpenses = [
    "rent" => 1500,
    "utilities" => 200,
    "healthInsurance" => 200
];

$grossSalary = 48150;
$socialSecurity = $grossSalary * .062;

$incomeSegments = [[9700, .88], [29775, .78], [8675, .76]];

// Write your code below:

// calculate Bob's net income using the income segments
$netIncome = ($incomeSegments[0][0] * $incomeSegments[0][1]) + ($incomeSegments[1][0] * $incomeSegments[1][1]) + ($incomeSegments[2][0] * $incomeSegments[2][1]);

// subtract social security tax from net income
$annualIncome = $netIncome - $socialSecurity;

// subtract annual expenses from annual income
$annualIncome -= $annualExpenses['vacations'];
$annualIncome -= $annualExpenses['carRepairs'];
echo "\nAnnual income after calculation:\n$annualIncome\n";
// Annual income after calculation: 33368.2

$monthlyIncome = $annualIncome / 12; 
echo "\nMonthly income before deducting monthly expenses: \n$monthlyIncome\n";
// Monthly income before deducting monthly expenses: 2780.6833333333

$monthlyIncome -= $monthlyExpenses['rent'];
$monthlyIncome -= $monthlyExpenses['utilities'];
$monthlyIncome -= $monthlyExpenses['healthInsurance'];

echo"\nMonthly income after deducting monthly expenses:\n$monthlyIncome\n";
// Monthly income after deducting monthly expenses:880.68333333333

$weeklyIncome = $monthlyIncome / 4.33;
echo"\nWeekly income before deducting weekly expenses:\n$weeklyIncome\n";
// Weekly income before deducting weekly expenses:203.39107005389

$weeklyExpenses = ['gas' => 25, 'food' => 90, 'entertainment' => 47];

$weeklyIncome -= $weeklyExpenses['gas'];
$weeklyIncome -= $weeklyExpenses['food'];
$weeklyIncome -= $weeklyExpenses['entertainment'];
echo"\nWeekly income after deducting weekly expenses:\n$weeklyIncome\n";
// Weekly income after deducting weekly expenses:41.391070053888

$yearlySavings = $weeklyIncome * 52;
echo "\nYearly savings after taxes and expenses:\n$yearlySavings\n";
// Yearly savings after taxes and expenses:2152.3356428022