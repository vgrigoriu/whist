# No trump

-> id = 85e7e6a3-3be3-49f8-a5b6-f043b530bb36
-> lifecycle = Acceptance
-> max-retries = 0
-> last-updated = 2017-02-19T14:19:07.1802682Z
-> tags = 


The other players must play a card of the same suit if possible.


[ValidPlays]
|> NoTrump
|> YourHandIs cards=🂡🂢🂱🂲🃁🃂🃑🃒
|> InitialCardIs card=🂳
|> ValidPlays value=🂱🂲
~~~


A player who has no cards of the suit led and no trumps can discard any card.


[ValidPlays]
|> NoTrump
|> YourHandIs cards=🂡🂢🃁🃂🃑🃒
|> InitialCardIs card=🂳
|> ValidPlays value=🂡🂢🃁🃂🃑🃒
~~~
