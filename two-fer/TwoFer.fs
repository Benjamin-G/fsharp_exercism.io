﻿module TwoFer
#indent "off"

let twoFer (input: string option): string =
	defaultArg input "you"
	|> sprintf "One for %s, one for me."