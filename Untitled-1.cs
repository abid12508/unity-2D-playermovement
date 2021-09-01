public movespeed = 5f; //could be any speed


void Update(){
Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
//new vector3 basically just x, y, and z values.
transform.position += movement * Time.deltaTime * movespeed;
//transform the position of the object using vector3 and the movespeed
} // update function






// if you want to make your player go up, down, left, and right you can just do
Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

//if you want to jump
void Jump(){
        if(Input.GetKeyDown(KeyCode.Space)){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 8f), ForceMode2D.Impulse);
    
}
//add the jump function to the Update function
Jump();


//moving left and right. nonstop jumping (flappy bird type game).
void Update()
    {   Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * movespeed;

    }
    void Jump(){
        if(Input.GetKeyDown(KeyCode.Space)){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 8f), ForceMode2D.Impulse);
    
}