IFlowchart - ATM Machine

Card read in  read card number and receive pin

if pin incorrect, 

   print invalid pin, re-enter
    if this the third time invalid pin print invalid pin and take card
       end program.

if nothing happens after thirty seconds print - timeout. 
   Go back to first page.

If pin valid

      select transaction

       withdraw cash
         check withdrawal amount is equal or greater to amount in account
         subtract amount in account
         ask for another transaction
       deposit cash
         enter amount 
           check if amount okay
            if yes - deposit amount and add to amount in account
           else
             pop up amount want to change or select transaction
           when transaction over, ask if want another transaction
        display amount
           ask if display on screen or print out
           ask for another transaction.
If transaction no, end session. 

