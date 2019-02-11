<?php
require('functions.php');
session_start();
require 'vendor/autoload.php';
$client = new \GuzzleHttp\Client();
$response = $client->request('GET', 'https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1');
$response_data = json_decode($response->getBody(), TRUE);
$response2 = $client->request('GET', 'https://deckofcardsapi.com/api/deck/'.$response_data['deck_id'].'/draw/?count=2');
$response_data2 = json_decode($response2->getBody(), TRUE);
$card_array = $response_data2['cards'];
$card_total = calc_card_total($card_array);
$_SESSION['card_array'] = $card_array;
$_SESSION['deck_id'] = $response_data['deck_id'];
$remaining_cards = $response_data2['remaining'];
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Black Jack</title>
</head>
<body>
    <?php foreach($card_array as $card) : ?>
       <img src="<?=$card['image']?>">
    <?php endforeach; ?>
    <h1><?php echo "Your card total is $card_total. There are $remaining_cards cards remaining."; ?></h1>
    <?php if($card_total > 21): ?>
       Sorry your total is above 21
       <a href="index.php">Play Again</a>
   <?php elseif($card_total == 21): ?>
       You win, take a trip to Vegas
       <a href="index.php">Play Again</a>
   <?php else: ?>
       <a href="drawagain.php"><input type=submit href="drawagain.php" value="draw again"></a>
   <?php endif; ?>
</body>
</html>