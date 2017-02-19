# With trump

-> id = 76be05c4-d3ba-402c-9c18-9a31bf2da8dd
-> lifecycle = Acceptance
-> max-retries = 0
-> last-updated = 2017-02-19T14:19:40.5632584Z
-> tags = 


The other players must play a card of the same suit if possible.


[ValidPlays]
|> TheTrumpIs trump=Diamonds
|> YourHandIs cards=🂡🂢🂱🂲🃁🃂🃑🃒
|> InitialCardIs card=🂳
|> ValidPlays value=🂱🂲
~~~


Any player who has no card of the suit led must play a trump if they can.


[ValidPlays]
|> TheTrumpIs trump=Diamonds
|> YourHandIs cards=🂡🂢🃁🃂🃑🃒
|> InitialCardIs card=🂳
|> ValidPlays value=🃁🃂
~~~


A player who has no cards of the suit led and no trumps can discard any card.


[ValidPlays]
|> TheTrumpIs trump=Diamonds
|> YourHandIs cards=🂡🂢🃑🃒
|> InitialCardIs card=🂳
|> ValidPlays value=🂡🂢🃑🃒
~~~
