Some tests using curl

1) build and make sure that the api is running
2) make appropriate changes to create_new_user.json
3) execute create_new_user.bat
4) assert that you get a success status code in return

1) alter your userid and pwd into get_token.txt
2) execute get_token.bat
3) take note of the token you get in response

1) remove authorization-header from get_orders.bat and attempt to execute in
2) assert you get 401
3) put back the authnz header into get_orders.bat
