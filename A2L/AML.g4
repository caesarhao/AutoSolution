grammar AML;

a2ml
	:	Begin 'A2ML'
			.*
		End 'A2ML'
	;

Begin :	'/begin';
End : '/end';
