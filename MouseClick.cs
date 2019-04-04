using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MouseClick : MonoBehaviour
{
    public Camera camera;
    Ray ray;
    RaycastHit hit;
    public AudioClip chickenSound;
    public AudioClip bearSound;
    public AudioClip haa;
    public AudioClip wallet;
    public AudioClip fingernail;
    public AudioClip zarfa;
    //ball
    public AudioClip ball;
    //bone
    public AudioClip bone;
    //dog
    public AudioClip dog;
    //back
    public AudioClip back;
    //gazal
    public AudioClip gazal;
    //glue
    public AudioClip glue;
    //submarine
    public AudioClip submarine;
    //gorab
    public AudioClip gorab;
    //aparrot
    public AudioClip aparrot;
    //Gorilla
    public AudioClip Gorilla;
    //home
    public AudioClip home;
    //WashingMachine
    public AudioClip WashingMachine;
    //Ladle
    public AudioClip Ladle;
    //farms
    public AudioClip farms;
    //tamar
    public AudioClip tamar;
    //Pyramid
    public AudioClip Pyramid;
    //gift
    public AudioClip gift;
    //hodhod
    public AudioClip hodhod;
    //moon
    public AudioClip moon;
    //tiger
    public AudioClip tiger;
    //bike
    public AudioClip bike;
    //babyface
    public AudioClip babyface;
    //lion
    public AudioClip lion;
    //cave
    public AudioClip cave;
    //oil
    public AudioClip oil;
    //bird
    public AudioClip bird;
    //egg
    public AudioClip egg;
    //orange
    public AudioClip orange;
    //Hand
    public AudioClip Hand;
    //eye
    public AudioClip eye;
    //office
    public AudioClip office;

    //boat
    public AudioClip boat;
    //fish
    public AudioClip fish;
    //chair
    public AudioClip chair;
    //rocket
    public AudioClip rocket;
    //frog
    public AudioClip frog;
    //police
    public AudioClip police;
    //deb
    public AudioClip dab;
    //teeth
    public AudioClip teeth;
    //vegetable
    public AudioClip vegetable;
    //wood
    public AudioClip wood;
    //eagle
    public AudioClip eagle;
    //image
    public AudioClip image;
    //sectors
    public AudioClip sectors;
    //castle
    public AudioClip castle;
    //lamp
    public AudioClip lamp;
    //box
    public AudioClip box;
    //palm
    public AudioClip palm;
    //bread
    public AudioClip bread;
    //kyar
    public AudioClip kyar;
    //sheep
    public AudioClip sheep;
    //safandi
    public AudioClip safandi;
    //snake
    public AudioClip snake;
    //dress
    public AudioClip dress;
    //ice
    public AudioClip ice;
    //two
    public AudioClip two;
    //flour
    public AudioClip flour;
    //molkhya
    public AudioClip molkhya;
    //paper
    public AudioClip paper;
    //boy
    public AudioClip boy;
    //arrow
    public AudioClip arrow;

    //medicne
    public AudioClip medicne;
    //Lamppost
    public AudioClip Lamppost;
    //rope
    public AudioClip rope;
    //honey
    public AudioClip honey;
    //flag
    public AudioClip flag;

    //grape
    public AudioClip grape;
    //wolf
    public AudioClip wolf;
    //grass
    public AudioClip grass;
    //daqn
    public AudioClip daqn;
    //ear
    public AudioClip ear;
    //corn
    public AudioClip corn;
    //gold
    public AudioClip gold;
    //plant
    public AudioClip plant;
    //tail
    public AudioClip tail;
    //qonfoz
    public AudioClip qonfoz;
    //sun
    public AudioClip sun;
    //candle
    public AudioClip candle;
    //nest
    public AudioClip nest;
    //sra3h
    public AudioClip sra3h;
    //fire
    public AudioClip fire;
    //tree
    public AudioClip tree;
    //duck
    public AudioClip duck;
    //stomach
    public AudioClip stomach;
    //rain
    public AudioClip rain;
    //birds
    public AudioClip birds;
    //tomato
    public AudioClip tomato;
    //cotton
    public AudioClip cotton;
    //child
    public AudioClip child;
    //dish
    public AudioClip dish;
    //pencil
    public AudioClip pencil;
    //cow
    public AudioClip cow;
    //engineer
    public AudioClip engineer;
    //stair
    public AudioClip stair;
    //enaa
    public AudioClip enaa;
    //doda
    public AudioClip doda;
    //tank
    public AudioClip tank;
    //olive
    public AudioClip olive;
    //bottle
    public AudioClip bottle;
    //zena
    public AudioClip zena;
    //farm
    public AudioClip farm;
    //banana
    public AudioClip banana;
    //qeraf
    public AudioClip qeraf;
    //zorar
    public AudioClip zorar;
    //camel
    public AudioClip camel;
    //bell
    public AudioClip bell;
    //sock
    public AudioClip sock;
    //bridge
    public AudioClip bridge;
    //leg
    public AudioClip leg;
    //cheese
    public AudioClip cheese;
    //tower
    public AudioClip tower;
    //carrot
    public AudioClip carrot;
    //face
    public AudioClip face;
    //sengab
    public AudioClip sengab;
    //berry
    public AudioClip berry;
    //k5tem
    public AudioClip ktem;
    //ink
    public AudioClip ink;
    //roman
    public AudioClip roman;
    //rabbit
    public AudioClip rabbit;
    //stone
    public AudioClip stone;
    //monkey
    public AudioClip monkey;
    //car
    public AudioClip car;
    //horse
    public AudioClip horse;
    //cloud
    public AudioClip cloud;
    //tortoise
    public AudioClip tortoise;
    //sharke
   
    //meat
    public AudioClip meat;
    //lemin
    public AudioClip lemon;
    //lsan
    public AudioClip lsan;
    //milk
    public AudioClip milk;
    //star
    public AudioClip star;
    //watermalon
    public AudioClip watermalon;
    //bee
    public AudioClip bee;
    //butterfly
    public AudioClip butterfly;
    //elephant
    public AudioClip elephant;
    //nose
    public AudioClip nose;
    //door
    public AudioClip door;
    //book
    public AudioClip book;
    //iron
    public AudioClip iron;
    //teacher
    public AudioClip teacher;
    //onion
    public AudioClip onion;
    //mishmish
    public AudioClip mishmish;
    //oktbot
    public AudioClip oktbot;

    //ras
    public AudioClip ras;
    //nail
    public AudioClip nail;
    //cup
    public AudioClip cup;
    //rat
    public AudioClip rat;
    //toy
    public AudioClip toy;
    //h
    public AudioClip h;
    //f
    public AudioClip f;
    //e
    public AudioClip e;
    //u
    public AudioClip u;
    //geem
    public AudioClip geem;
    //o
    public AudioClip o;
    //dal
    public AudioClip dal;
    //w
    public AudioClip w;
    //taa
    public AudioClip taa;
    //j
    public AudioClip j;
    //q
    public AudioClip q;
    //r
    public AudioClip r;
    //y
    public AudioClip y;
    //t
    public AudioClip t;
    //kaf
    public AudioClip kaf;
    //l
    public AudioClip l;
    //k
    public AudioClip k;
    //i
    public AudioClip i;
    //d
    public AudioClip d;
    //a
    public AudioClip a;
    //s
    public AudioClip s;
    //zal
    public AudioClip zal;
    //ro
    public AudioClip ro;
    //zo
    public AudioClip zo;
    //snara
    public AudioClip snara;

    //halak
    public AudioClip halak;
    //wheat
    public AudioClip wheat;
    //foot
    public AudioClip foot;
    //train
    public AudioClip train;
    //moga
    public AudioClip moga;
    //sarag
    public AudioClip sarag;
    //crown
    public AudioClip crown;
    //CROCODIL
    public AudioClip CROCODIL;
    //geraf
    public AudioClip geraf;
    //dab3
    public AudioClip dab3;
    //hand
    public AudioClip hand;
    //trainroad
    public AudioClip trainroad;
    //body
    public AudioClip body;
    //woow
    public AudioClip woow;
    //ballon
    public AudioClip ballon;
    //fanous
    public AudioClip fanous;
    //fagel
    public AudioClip fagel;
    //romey
    public AudioClip romey;
    //sabora
    public AudioClip sabora;
    //sugar
    public AudioClip sugar;
    //selsla
    public AudioClip selsla;
    //dra3
    public AudioClip dra3;
    //belt
    public AudioClip belt;
    //ard
    public AudioClip ard;
    //dal
    public AudioClip dall;
    //ras5
    public AudioClip ras5;
    //rock
    public AudioClip rock;
    //solider
    public AudioClip solider;
    //singer
    public AudioClip singer;
    public AudioClip sharke;
    //hoot
    public AudioClip hoot;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            //hoot
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "hoot")
                AudioSource.PlayClipAtPoint(hoot, new Vector3(0, 0, 0), 1f);

            //singer
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "singer")
                AudioSource.PlayClipAtPoint(singer, new Vector3(0, 0, 0), 1f);
            //rock
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "rock")
                AudioSource.PlayClipAtPoint(rock, new Vector3(0, 0, 0), 1f);
            //solider
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "solider")
                AudioSource.PlayClipAtPoint(solider, new Vector3(0, 0, 0), 1f);
            //dall
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "dall")
                AudioSource.PlayClipAtPoint(dall, new Vector3(0, 0, 0), 1f);
            //ras5
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "ras5")
                AudioSource.PlayClipAtPoint(ras5, new Vector3(0, 0, 0), 1f);
            //ard
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "ard")
                AudioSource.PlayClipAtPoint(ard, new Vector3(0, 0, 0), 1f);
            //belt
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "belt")
                AudioSource.PlayClipAtPoint(belt, new Vector3(0, 0, 0), 1f);
            //dra3
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "dra3")
                AudioSource.PlayClipAtPoint(dra3, new Vector3(0, 0, 0), 1f);

            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "chicken")
                AudioSource.PlayClipAtPoint(chickenSound, new Vector3(0, 0, 0), 1f);

            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "bear")
                AudioSource.PlayClipAtPoint(bearSound, new Vector3(0, 0, 0), 1f);
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "haa")
                AudioSource.PlayClipAtPoint(haa, new Vector3(0, 0, 0), 1f);
            //wallet
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "wallet")
                AudioSource.PlayClipAtPoint(wallet, new Vector3(0, 0, 0), 1f);
            //fingre nail
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "finaill")
                AudioSource.PlayClipAtPoint(fingernail, new Vector3(0, 0, 0), 1f);
            //zarfa
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "zarfa")
                AudioSource.PlayClipAtPoint(zarfa, new Vector3(0, 0, 0), 1f);
            //ball
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "ball")
                AudioSource.PlayClipAtPoint(ball, new Vector3(0, 0, 0), 1f);
            //bone
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "bone")
                AudioSource.PlayClipAtPoint(bone, new Vector3(0, 0, 0), 1f);
            //dog
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "dog")
                AudioSource.PlayClipAtPoint(dog, new Vector3(0, 0, 0), 1f);
            //back
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "back")
                AudioSource.PlayClipAtPoint(back, new Vector3(0, 0, 0), 1f);
            //gazal 
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "gazal")
                AudioSource.PlayClipAtPoint(gazal, new Vector3(0, 0, 0), 1f);
            //glue
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "glue")
                AudioSource.PlayClipAtPoint(glue, new Vector3(0, 0, 0), 1f);
            //submarine
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "submarine")
                AudioSource.PlayClipAtPoint(submarine, new Vector3(0, 0, 0), 1f);
            //gorab
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "gorab")
                AudioSource.PlayClipAtPoint(gorab, new Vector3(0, 0, 0), 1f);
            //a parrot
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "a parrot")
                AudioSource.PlayClipAtPoint(aparrot, new Vector3(0, 0, 0), 1f);
            //Gorilla
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "Gorilla")
                AudioSource.PlayClipAtPoint(Gorilla, new Vector3(0, 0, 0), 1f);
            //home
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "home")
                AudioSource.PlayClipAtPoint(home, new Vector3(0, 0, 0), 1f);
            //WashingMachine
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "WashingMachine")
                AudioSource.PlayClipAtPoint(WashingMachine, new Vector3(0, 0, 0), 1f);
            //Ladle
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "Ladle")
                AudioSource.PlayClipAtPoint(Ladle, new Vector3(0, 0, 0), 1f);
            //farms
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "farms")
                AudioSource.PlayClipAtPoint(farms, new Vector3(0, 0, 0), 1f);
            //tamar
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "tamar")
                AudioSource.PlayClipAtPoint(tamar, new Vector3(0, 0, 0), 1f);
            //Pyramid
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "Pyramid")
                AudioSource.PlayClipAtPoint(Pyramid, new Vector3(0, 0, 0), 1f);
            //gift
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "gift")
                AudioSource.PlayClipAtPoint(gift, new Vector3(0, 0, 0), 1f);
            //hodhod
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "hodhod")
                AudioSource.PlayClipAtPoint(hodhod, new Vector3(0, 0, 0), 1f);
            //moon
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "moon")
                AudioSource.PlayClipAtPoint(moon, new Vector3(0, 0, 0), 1f);
            //tiger
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "tiger")
                AudioSource.PlayClipAtPoint(tiger, new Vector3(0, 0, 0), 1f);
            //bike
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "bike")
                AudioSource.PlayClipAtPoint(bike, new Vector3(0, 0, 0), 1f);
            //babyface
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "babyface")
                AudioSource.PlayClipAtPoint(babyface, new Vector3(0, 0, 0), 1f);
            //lion
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "lion")
                AudioSource.PlayClipAtPoint(lion, new Vector3(0, 0, 0), 1f);
            //cave
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "cave")
                AudioSource.PlayClipAtPoint(cave, new Vector3(0, 0, 0), 1f);
            //oil
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "oil")
                AudioSource.PlayClipAtPoint(oil, new Vector3(0, 0, 0), 1f);
            //bird
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "bird")
                AudioSource.PlayClipAtPoint(bird, new Vector3(0, 0, 0), 1f);
            //egg
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "egg")
                AudioSource.PlayClipAtPoint(egg, new Vector3(0, 0, 0), 1f);
            //orange
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "orange")
                AudioSource.PlayClipAtPoint(orange, new Vector3(0, 0, 0), 1f);
            //Hand
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "Hand")
                AudioSource.PlayClipAtPoint(Hand, new Vector3(0, 0, 0), 1f);
            //eye
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "eye")
                AudioSource.PlayClipAtPoint(eye, new Vector3(0, 0, 0), 1f);
            //office
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "office")
                AudioSource.PlayClipAtPoint(office, new Vector3(0, 0, 0), 1f);
            //book
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "book")
                AudioSource.PlayClipAtPoint(book, new Vector3(0, 0, 0), 1f);
            //boat
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "boat")
                AudioSource.PlayClipAtPoint(boat, new Vector3(0, 0, 0), 1f);
            //fish
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "fish")
                AudioSource.PlayClipAtPoint(fish, new Vector3(0, 0, 0), 1f);
            //chair
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "chair")
                AudioSource.PlayClipAtPoint(chair, new Vector3(0, 0, 0), 1f);

            //rocket
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "rocket")
                AudioSource.PlayClipAtPoint(rocket, new Vector3(0, 0, 0), 1f);
            //frog
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "frog")
                AudioSource.PlayClipAtPoint(frog, new Vector3(0, 0, 0), 1f);
            //police
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "police")
                AudioSource.PlayClipAtPoint(police, new Vector3(0, 0, 0), 1f);
            //deb
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "dab")
                AudioSource.PlayClipAtPoint(dab, new Vector3(0, 0, 0), 1f);
            //teeth
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "teeth")
                AudioSource.PlayClipAtPoint(teeth, new Vector3(0, 0, 0), 1f);
            //vegetable
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "vegetable")
                AudioSource.PlayClipAtPoint(vegetable, new Vector3(0, 0, 0), 1f);
            //wood
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "wood")
                AudioSource.PlayClipAtPoint(wood, new Vector3(0, 0, 0), 1f);

            //eagle
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "eagle")
                AudioSource.PlayClipAtPoint(eagle, new Vector3(0, 0, 0), 1f);
            //image
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "image")
                AudioSource.PlayClipAtPoint(image, new Vector3(0, 0, 0), 1f);
            //sectors
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "sectors")
                AudioSource.PlayClipAtPoint(sectors, new Vector3(0, 0, 0), 1f);
            //castle
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "castle")
                AudioSource.PlayClipAtPoint(castle, new Vector3(0, 0, 0), 1f);
            //lamp
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "lamp")
                AudioSource.PlayClipAtPoint(lamp, new Vector3(0, 0, 0), 1f);
            //box
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "box")
                AudioSource.PlayClipAtPoint(box, new Vector3(0, 0, 0), 1f);
            //palm
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "palm")
                AudioSource.PlayClipAtPoint(palm, new Vector3(0, 0, 0), 1f);
            //bread
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "bread")
                AudioSource.PlayClipAtPoint(bread, new Vector3(0, 0, 0), 1f);
            //kyar
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "kyar")
                AudioSource.PlayClipAtPoint(kyar, new Vector3(0, 0, 0), 1f);
            //sheep
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "sheep")
                AudioSource.PlayClipAtPoint(sheep, new Vector3(0, 0, 0), 1f);
            //safandi
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "safandi")
                AudioSource.PlayClipAtPoint(safandi, new Vector3(0, 0, 0), 1f);
            //snake
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "snake")
                AudioSource.PlayClipAtPoint(snake, new Vector3(0, 0, 0), 1f);
            //dress
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "dress")
                AudioSource.PlayClipAtPoint(dress, new Vector3(0, 0, 0), 1f);
            //ice
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "ice")
                AudioSource.PlayClipAtPoint(ice, new Vector3(0, 0, 0), 1f);
            //two
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "two")
                AudioSource.PlayClipAtPoint(two, new Vector3(0, 0, 0), 1f);
            //flour
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "flour")
                AudioSource.PlayClipAtPoint(flour, new Vector3(0, 0, 0), 1f);
            //molkhya
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "molkhya")
                AudioSource.PlayClipAtPoint(molkhya, new Vector3(0, 0, 0), 1f);
            //paper
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "paper")
                AudioSource.PlayClipAtPoint(paper, new Vector3(0, 0, 0), 1f);
            //boy
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "boy")
                AudioSource.PlayClipAtPoint(boy, new Vector3(0, 0, 0), 1f);
            //arrow
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "arrow")
                AudioSource.PlayClipAtPoint(arrow, new Vector3(0, 0, 0), 1f);
            //medicne
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "medicne")
                AudioSource.PlayClipAtPoint(medicne, new Vector3(0, 0, 0), 1f);
            //Lamppost
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "Lamppost")
                AudioSource.PlayClipAtPoint(Lamppost, new Vector3(0, 0, 0), 1f);
            //rope
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "rope")
                AudioSource.PlayClipAtPoint(rope, new Vector3(0, 0, 0), 1f);
            //honey
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "honey")
                AudioSource.PlayClipAtPoint(honey, new Vector3(0, 0, 0), 1f);
            //flag
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "flag")
                AudioSource.PlayClipAtPoint(flag, new Vector3(0, 0, 0), 1f);

            //grape
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "grape")
                AudioSource.PlayClipAtPoint(grape, new Vector3(0, 0, 0), 1f);
            //wolf
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "wolf")
                AudioSource.PlayClipAtPoint(wolf, new Vector3(0, 0, 0), 1f);
            //grass
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "grass")
                AudioSource.PlayClipAtPoint(grass, new Vector3(0, 0, 0), 1f);
            //daqn
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "daqn")
                AudioSource.PlayClipAtPoint(daqn, new Vector3(0, 0, 0), 1f);
            //ear
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "ear")
                AudioSource.PlayClipAtPoint(ear, new Vector3(0, 0, 0), 1f);
            //corn
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "corn")
                AudioSource.PlayClipAtPoint(corn, new Vector3(0, 0, 0), 1f);
            //gold
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "gold")
                AudioSource.PlayClipAtPoint(gold, new Vector3(0, 0, 0), 1f);
            //plant
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "plant")
                AudioSource.PlayClipAtPoint(plant, new Vector3(0, 0, 0), 1f);
            //tail
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "tail")
                AudioSource.PlayClipAtPoint(tail, new Vector3(0, 0, 0), 1f);
            //qonfoz
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "qonfoz")
                AudioSource.PlayClipAtPoint(qonfoz, new Vector3(0, 0, 0), 1f);
            //sun
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "sun")
                AudioSource.PlayClipAtPoint(sun, new Vector3(0, 0, 0), 1f);
            //candle
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "candle")
                AudioSource.PlayClipAtPoint(candle, new Vector3(0, 0, 0), 1f);
            //nest
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "nest")
                AudioSource.PlayClipAtPoint(nest, new Vector3(0, 0, 0), 1f);
            //sra3h
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "sra3h")
                AudioSource.PlayClipAtPoint(sra3h, new Vector3(0, 0, 0), 1f);
            //fire
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "fire")
                AudioSource.PlayClipAtPoint(fire, new Vector3(0, 0, 0), 1f);
            //tree
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "tree")
                AudioSource.PlayClipAtPoint(tree, new Vector3(0, 0, 0), 1f);
            //duck
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "duck")
                AudioSource.PlayClipAtPoint(duck, new Vector3(0, 0, 0), 1f);
            //stomach
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "stomach")
                AudioSource.PlayClipAtPoint(stomach, new Vector3(0, 0, 0), 1f);
            //rain
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "rain")
                AudioSource.PlayClipAtPoint(rain, new Vector3(0, 0, 0), 1f);
            //birds
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "birds")
                AudioSource.PlayClipAtPoint(birds, new Vector3(0, 0, 0), 1f);
            //tomato
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "tomato")
                AudioSource.PlayClipAtPoint(tomato, new Vector3(0, 0, 0), 1f);
            //cotton
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "cotton")
                AudioSource.PlayClipAtPoint(cotton, new Vector3(0, 0, 0), 1f);
            //child
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "child")
                AudioSource.PlayClipAtPoint(child, new Vector3(0, 0, 0), 1f);
            //dish
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "dish")
                AudioSource.PlayClipAtPoint(dish, new Vector3(0, 0, 0), 1f);
            //pencil
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "pencil")
                AudioSource.PlayClipAtPoint(pencil, new Vector3(0, 0, 0), 1f);
            //cow
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "cow")
                AudioSource.PlayClipAtPoint(cow, new Vector3(0, 0, 0), 1f);
            //engineer
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "engineer")
                AudioSource.PlayClipAtPoint(engineer, new Vector3(0, 0, 0), 1f);
            //stair
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "stair")
                AudioSource.PlayClipAtPoint(stair, new Vector3(0, 0, 0), 1f);
            //enaa
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "enaa")
                AudioSource.PlayClipAtPoint(enaa, new Vector3(0, 0, 0), 1f);
            //doda
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "doda")
                AudioSource.PlayClipAtPoint(doda, new Vector3(0, 0, 0), 1f);
            //tank
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "tank")
                AudioSource.PlayClipAtPoint(tank, new Vector3(0, 0, 0), 1f);
            //olive
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "olive")
                AudioSource.PlayClipAtPoint(olive, new Vector3(0, 0, 0), 1f);
            //bottle
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "bottle")
                AudioSource.PlayClipAtPoint(bottle, new Vector3(0, 0, 0), 1f);
            //zena
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "zena")
                AudioSource.PlayClipAtPoint(zena, new Vector3(0, 0, 0), 1f);
            //farm
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "farm")
                AudioSource.PlayClipAtPoint(farm, new Vector3(0, 0, 0), 1f);
            //banana
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "banana")
                AudioSource.PlayClipAtPoint(banana, new Vector3(0, 0, 0), 1f);
            //qeraf
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "qeraf")
                AudioSource.PlayClipAtPoint(qeraf, new Vector3(0, 0, 0), 1f);
            //zorar
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "zorar")
                AudioSource.PlayClipAtPoint(zorar, new Vector3(0, 0, 0), 1f);
            //camel
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "camel")
                AudioSource.PlayClipAtPoint(camel, new Vector3(0, 0, 0), 1f);
            //bell
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "bell")
                AudioSource.PlayClipAtPoint(bell, new Vector3(0, 0, 0), 1f);
            //sock
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "sock")
                AudioSource.PlayClipAtPoint(sock, new Vector3(0, 0, 0), 1f);
            //bridge
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "bridge")
                AudioSource.PlayClipAtPoint(bridge, new Vector3(0, 0, 0), 1f);
            //leg
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "leg")
                AudioSource.PlayClipAtPoint(leg, new Vector3(0, 0, 0), 1f);
            //cheese
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "cheese")
                AudioSource.PlayClipAtPoint(cheese, new Vector3(0, 0, 0), 1f);
            //tower
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "tower")
                AudioSource.PlayClipAtPoint(tower, new Vector3(0, 0, 0), 1f);
            //carrot
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "carrot")
                AudioSource.PlayClipAtPoint(carrot, new Vector3(0, 0, 0), 1f);
            //face
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "face")
                AudioSource.PlayClipAtPoint(face, new Vector3(0, 0, 0), 1f);
            //sengab
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "sengab")
                AudioSource.PlayClipAtPoint(sengab, new Vector3(0, 0, 0), 1f);
            //berry
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "berry")
                AudioSource.PlayClipAtPoint(berry, new Vector3(0, 0, 0), 1f);
            //k5tem
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "5tem")
                AudioSource.PlayClipAtPoint(ktem, new Vector3(0, 0, 0), 1f);
            //ink
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "ink")
                AudioSource.PlayClipAtPoint(ink, new Vector3(0, 0, 0), 1f);
            //roman
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "roman")
                AudioSource.PlayClipAtPoint(roman, new Vector3(0, 0, 0), 1f);
            //rabbit
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "rabbit")
                AudioSource.PlayClipAtPoint(rabbit, new Vector3(0, 0, 0), 1f);
            //stone
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "stone")
                AudioSource.PlayClipAtPoint(stone, new Vector3(0, 0, 0), 1f);
            //monkey
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "monkey")
                AudioSource.PlayClipAtPoint(monkey, new Vector3(0, 0, 0), 1f);
            //car
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "car")
                AudioSource.PlayClipAtPoint(car, new Vector3(0, 0, 0), 1f);
            //horse
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "horse")
                AudioSource.PlayClipAtPoint(horse, new Vector3(0, 0, 0), 1f);
            //cloud
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "cloud")
                AudioSource.PlayClipAtPoint(cloud, new Vector3(0, 0, 0), 1f);
            //tortoise
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "tortoise")
                AudioSource.PlayClipAtPoint(tortoise, new Vector3(0, 0, 0), 1f);
            //sharke
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "sharke")
                AudioSource.PlayClipAtPoint(sharke, new Vector3(0, 0, 0), 1f);
            //meat
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "meat")
                AudioSource.PlayClipAtPoint(meat, new Vector3(0, 0, 0), 1f);
            //lemon
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "lemon")
                AudioSource.PlayClipAtPoint(lemon, new Vector3(0, 0, 0), 1f);
            //lsan
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "lsan")
                AudioSource.PlayClipAtPoint(lsan, new Vector3(0, 0, 0), 1f);
            //milk
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "milk")
                AudioSource.PlayClipAtPoint(milk, new Vector3(0, 0, 0), 1f);
            //star
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "star")
                AudioSource.PlayClipAtPoint(star, new Vector3(0, 0, 0), 1f);
            //watermalon
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "watermalon")
                AudioSource.PlayClipAtPoint(watermalon, new Vector3(0, 0, 0), 1f);
            //bee
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "bee")
                AudioSource.PlayClipAtPoint(bee, new Vector3(0, 0, 0), 1f);
            //butterfly
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "butterfly")
                AudioSource.PlayClipAtPoint(butterfly, new Vector3(0, 0, 0), 1f);
            //elephant
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "elephant")
                AudioSource.PlayClipAtPoint(elephant, new Vector3(0, 0, 0), 1f);
            //nose
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "nose")
                AudioSource.PlayClipAtPoint(nose, new Vector3(0, 0, 0), 1f);
            //door
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "door")
                AudioSource.PlayClipAtPoint(door, new Vector3(0, 0, 0), 1f);
            //book
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "book")
                AudioSource.PlayClipAtPoint(book, new Vector3(0, 0, 0), 1f);
            //iron
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "iron")
                AudioSource.PlayClipAtPoint(iron, new Vector3(0, 0, 0), 1f);
            //teacher
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "teacher")
                AudioSource.PlayClipAtPoint(teacher, new Vector3(0, 0, 0), 1f);
            //onion
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "onion")
                AudioSource.PlayClipAtPoint(onion, new Vector3(0, 0, 0), 1f);
            //mishmish
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "mishmish")
                AudioSource.PlayClipAtPoint(mishmish, new Vector3(0, 0, 0), 1f);
            //oktbot
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "oktbot")
                AudioSource.PlayClipAtPoint(oktbot, new Vector3(0, 0, 0), 1f);
            //ras
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "ras")
                AudioSource.PlayClipAtPoint(ras, new Vector3(0, 0, 0), 1f);
            //nail
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "nail")
                AudioSource.PlayClipAtPoint(nail, new Vector3(0, 0, 0), 1f);
            //cup
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "cup")
                AudioSource.PlayClipAtPoint(cup, new Vector3(0, 0, 0), 1f);
            //rat
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "rat")
                AudioSource.PlayClipAtPoint(rat, new Vector3(0, 0, 0), 1f);
            //toy
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "toy")
                AudioSource.PlayClipAtPoint(toy, new Vector3(0, 0, 0), 1f);
            //h
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "h")
                AudioSource.PlayClipAtPoint(h, new Vector3(0, 0, 0), 1f);
            //f
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "f")
                AudioSource.PlayClipAtPoint(f, new Vector3(0, 0, 0), 1f);
            //e
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "e")
                AudioSource.PlayClipAtPoint(e, new Vector3(0, 0, 0), 1f);
            //u
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "u")
                AudioSource.PlayClipAtPoint(u, new Vector3(0, 0, 0), 1f);
            //geem
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "geem")
                AudioSource.PlayClipAtPoint(geem, new Vector3(0, 0, 0), 1f);
            //o
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "o")
                AudioSource.PlayClipAtPoint(o, new Vector3(0, 0, 0), 1f);
            //dal
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "dal")
                AudioSource.PlayClipAtPoint(dal, new Vector3(0, 0, 0), 1f);
            //w
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "w")
                AudioSource.PlayClipAtPoint(w, new Vector3(0, 0, 0), 1f);
            //taa
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "taa")
                AudioSource.PlayClipAtPoint(taa, new Vector3(0, 0, 0), 1f);

            //j
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "j")
                AudioSource.PlayClipAtPoint(j, new Vector3(0, 0, 0), 1f);
            //q
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "q")
                AudioSource.PlayClipAtPoint(q, new Vector3(0, 0, 0), 1f);
            //r
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "r")
                AudioSource.PlayClipAtPoint(r, new Vector3(0, 0, 0), 1f);
            //y
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "y")
                AudioSource.PlayClipAtPoint(y, new Vector3(0, 0, 0), 1f);
            //t
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "t")
                AudioSource.PlayClipAtPoint(t, new Vector3(0, 0, 0), 1f);
            //kaf
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "kaf")
                AudioSource.PlayClipAtPoint(kaf, new Vector3(0, 0, 0), 1f);
            //l
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "l")
                AudioSource.PlayClipAtPoint(l, new Vector3(0, 0, 0), 1f);
            //k
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "k")
                AudioSource.PlayClipAtPoint(k, new Vector3(0, 0, 0), 1f);
            //i
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "i")
                AudioSource.PlayClipAtPoint(i, new Vector3(0, 0, 0), 1f);
            //d
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "d")
                AudioSource.PlayClipAtPoint(d, new Vector3(0, 0, 0), 1f);
            //a
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "a")
                AudioSource.PlayClipAtPoint(a, new Vector3(0, 0, 0), 1f);
            //s
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "s")
                AudioSource.PlayClipAtPoint(s, new Vector3(0, 0, 0), 1f);
            //zal
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "zal")
                AudioSource.PlayClipAtPoint(zal, new Vector3(0, 0, 0), 1f);
            //ro
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "ro")
                AudioSource.PlayClipAtPoint(ro, new Vector3(0, 0, 0), 1f);
            //zo
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "zo")
                AudioSource.PlayClipAtPoint(zo, new Vector3(0, 0, 0), 1f);
            //snara
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "snara")
                AudioSource.PlayClipAtPoint(snara, new Vector3(0, 0, 0), 1f);

            //halak
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "halak")
                AudioSource.PlayClipAtPoint(halak, new Vector3(0, 0, 0), 1f);
            //wheat
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "wheat")
                AudioSource.PlayClipAtPoint(wheat, new Vector3(0, 0, 0), 1f);
            //foot
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "foot")
                AudioSource.PlayClipAtPoint(foot, new Vector3(0, 0, 0), 1f);
            //train
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "train")
                AudioSource.PlayClipAtPoint(train, new Vector3(0, 0, 0), 1f);
            //moga
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "moga")
                AudioSource.PlayClipAtPoint(moga, new Vector3(0, 0, 0), 1f);
            //sarag
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "sarag")
                AudioSource.PlayClipAtPoint(sarag, new Vector3(0, 0, 0), 1f);
            //crown
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "crown")
                AudioSource.PlayClipAtPoint(crown, new Vector3(0, 0, 0), 1f);
            //CROCODIL
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "CROCODIL")
                AudioSource.PlayClipAtPoint(CROCODIL, new Vector3(0, 0, 0), 1f);
            //geraf
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "geraf")
                AudioSource.PlayClipAtPoint(geraf, new Vector3(0, 0, 0), 1f);

            //dab3
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "dab3")
                AudioSource.PlayClipAtPoint(dab3, new Vector3(0, 0, 0), 1f);
            //hand
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "hand")
                AudioSource.PlayClipAtPoint(hand, new Vector3(0, 0, 0), 1f);
            //trainroad
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "trainroad")
                AudioSource.PlayClipAtPoint(trainroad, new Vector3(0, 0, 0), 1f);
            //body
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "body")
                AudioSource.PlayClipAtPoint(body, new Vector3(0, 0, 0), 1f);
            //woow
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "woow")
                AudioSource.PlayClipAtPoint(woow, new Vector3(0, 0, 0), 1f);
           
            //ballon
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "ballon")
                AudioSource.PlayClipAtPoint(ballon, new Vector3(0, 0, 0), 1f);
            //fanous
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "fanous")
                AudioSource.PlayClipAtPoint(fanous, new Vector3(0, 0, 0), 1f);
    //fagel
      if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "fagel")
                AudioSource.PlayClipAtPoint(fagel, new Vector3(0, 0, 0), 1f);
    //romey
    if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "romey")
                AudioSource.PlayClipAtPoint(romey, new Vector3(0, 0, 0), 1f);
    //sabora
       if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "sabora")
                AudioSource.PlayClipAtPoint(sabora, new Vector3(0, 0, 0), 1f);
            //sugar
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "sugar")
                AudioSource.PlayClipAtPoint(sugar, new Vector3(0, 0, 0), 1f);
            //selsla
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.tag == "selsla")
                AudioSource.PlayClipAtPoint(selsla, new Vector3(0, 0, 0), 1f);


        }
        if (Input.touches.Length != 0)
        {
            Touch touch = Input.touches[0];
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("chicken"))
                {
                    AudioSource.PlayClipAtPoint(chickenSound, new Vector3(0, 0, 0), 1f);
                }

                if (hit.collider.CompareTag("bear"))
                {
                    AudioSource.PlayClipAtPoint(bearSound, new Vector3(0, 0, 0), 1f);
                }

                if (hit.collider.CompareTag("haa"))
                {
                    AudioSource.PlayClipAtPoint(haa, new Vector3(0, 0, 0), 1f);
                }
                //wallet
                if (hit.collider.CompareTag("wallet"))
                {
                    AudioSource.PlayClipAtPoint(wallet, new Vector3(0, 0, 0), 1f);
                }
                ///finger  nai
                if (hit.collider.CompareTag("finaill"))
                {
                    AudioSource.PlayClipAtPoint(fingernail, new Vector3(0, 0, 0), 1f);
                }
                //zarfa
                if (hit.collider.CompareTag("zarfa"))
                {
                    AudioSource.PlayClipAtPoint(zarfa, new Vector3(0, 0, 0), 1f);
                }
                //ball
                if (hit.collider.CompareTag("ball"))
                {
                    AudioSource.PlayClipAtPoint(ball, new Vector3(0, 0, 0), 1f);
                }

                //bone
                if (hit.collider.CompareTag("bone"))
                {
                    AudioSource.PlayClipAtPoint(bone, new Vector3(0, 0, 0), 1f);
                }
                //dog
                if (hit.collider.CompareTag("dog"))
                {
                    AudioSource.PlayClipAtPoint(dog, new Vector3(0, 0, 0), 1f);
                }
                //back
                if (hit.collider.CompareTag("back"))
                {
                    AudioSource.PlayClipAtPoint(back, new Vector3(0, 0, 0), 1f);
                }
                //gazal
                if (hit.collider.CompareTag("gazal"))
                {
                    AudioSource.PlayClipAtPoint(gazal, new Vector3(0, 0, 0), 1f);
                }
                //glue
                if (hit.collider.CompareTag("glue"))
                {
                    AudioSource.PlayClipAtPoint(glue, new Vector3(0, 0, 0), 1f);
                }
                //submarine
                if (hit.collider.CompareTag("submarine"))
                {
                    AudioSource.PlayClipAtPoint(submarine, new Vector3(0, 0, 0), 1f);
                }
                //gorab
                if (hit.collider.CompareTag("gorab"))
                {
                    AudioSource.PlayClipAtPoint(gorab, new Vector3(0, 0, 0), 1f);
                }
                //a parrot
                if (hit.collider.CompareTag("a parrot"))
                {
                    AudioSource.PlayClipAtPoint(aparrot, new Vector3(0, 0, 0), 1f);
                }
                //Gorilla
                if (hit.collider.CompareTag("Gorilla"))
                {
                    AudioSource.PlayClipAtPoint(Gorilla, new Vector3(0, 0, 0), 1f);
                }
                //home
                if (hit.collider.CompareTag("home"))
                {
                    AudioSource.PlayClipAtPoint(home, new Vector3(0, 0, 0), 1f);
                }
                //WashingMachine
                if (hit.collider.CompareTag("WashingMachine"))
                {
                    AudioSource.PlayClipAtPoint(WashingMachine, new Vector3(0, 0, 0), 1f);
                }
                //Ladle
                if (hit.collider.CompareTag("Ladle"))
                {
                    AudioSource.PlayClipAtPoint(Ladle, new Vector3(0, 0, 0), 1f);
                }
                //farms
                if (hit.collider.CompareTag("farms"))
                {
                    AudioSource.PlayClipAtPoint(farms, new Vector3(0, 0, 0), 1f);
                }
                //tamar
                if (hit.collider.CompareTag("tamar"))
                {
                    AudioSource.PlayClipAtPoint(tamar, new Vector3(0, 0, 0), 1f);
                }
                //Pyramid
                if (hit.collider.CompareTag("Pyramid"))
                {
                    AudioSource.PlayClipAtPoint(Pyramid, new Vector3(0, 0, 0), 1f);
                }
                //gift
                if (hit.collider.CompareTag("gift"))
                {
                    AudioSource.PlayClipAtPoint(gift, new Vector3(0, 0, 0), 1f);
                }
                //hodhod
                if (hit.collider.CompareTag("hodhod"))
                {
                    AudioSource.PlayClipAtPoint(hodhod, new Vector3(0, 0, 0), 1f);
                }
                //moon
                if (hit.collider.CompareTag("moon"))
                {
                    AudioSource.PlayClipAtPoint(moon, new Vector3(0, 0, 0), 1f);
                }
                //tiger
                if (hit.collider.CompareTag("tiger"))
                {
                    AudioSource.PlayClipAtPoint(tiger, new Vector3(0, 0, 0), 1f);
                }
                //bike
                if (hit.collider.CompareTag("bike"))
                {
                    AudioSource.PlayClipAtPoint(bike, new Vector3(0, 0, 0), 1f);
                }
                //babyface
                if (hit.collider.CompareTag("babyface"))
                {
                    AudioSource.PlayClipAtPoint(babyface, new Vector3(0, 0, 0), 1f);
                }
                //lion
                if (hit.collider.CompareTag("lion"))
                {
                    AudioSource.PlayClipAtPoint(lion, new Vector3(0, 0, 0), 1f);
                }
                //cave
                if (hit.collider.CompareTag("cave"))
                {
                    AudioSource.PlayClipAtPoint(cave, new Vector3(0, 0, 0), 1f);
                }
                //oil
                if (hit.collider.CompareTag("oil"))
                {
                    AudioSource.PlayClipAtPoint(oil, new Vector3(0, 0, 0), 1f);
                }
                //bird
                if (hit.collider.CompareTag("bird"))
                {
                    AudioSource.PlayClipAtPoint(bird, new Vector3(0, 0, 0), 1f);
                }
                //egg
                if (hit.collider.CompareTag("egg"))
                {
                    AudioSource.PlayClipAtPoint(egg, new Vector3(0, 0, 0), 1f);
                }
                //orange
                if (hit.collider.CompareTag("orange"))
                {
                    AudioSource.PlayClipAtPoint(orange, new Vector3(0, 0, 0), 1f);
                }
                //Hand
                if (hit.collider.CompareTag("Hand"))
                {
                    AudioSource.PlayClipAtPoint(Hand, new Vector3(0, 0, 0), 1f);
                }
                //eye
                if (hit.collider.CompareTag("eye"))
                {
                    AudioSource.PlayClipAtPoint(eye, new Vector3(0, 0, 0), 1f);
                }
                //office
                if (hit.collider.CompareTag("office"))
                {
                    AudioSource.PlayClipAtPoint(office, new Vector3(0, 0, 0), 1f);
                }
                //book
                if (hit.collider.CompareTag("book"))
                {
                    AudioSource.PlayClipAtPoint(book, new Vector3(0, 0, 0), 1f);
                }
                //boat
                if (hit.collider.CompareTag("boat"))
                {
                    AudioSource.PlayClipAtPoint(boat, new Vector3(0, 0, 0), 1f);
                }
                //fish
                if (hit.collider.CompareTag("fish"))
                {
                    AudioSource.PlayClipAtPoint(fish, new Vector3(0, 0, 0), 1f);
                }
                //chair
                if (hit.collider.CompareTag("chair"))
                {
                    AudioSource.PlayClipAtPoint(chair, new Vector3(0, 0, 0), 1f);
                }

                //rocket
                if (hit.collider.CompareTag("rocket"))
                {
                    AudioSource.PlayClipAtPoint(rocket, new Vector3(0, 0, 0), 1f);
                }
                //frog
                if (hit.collider.CompareTag("frog"))
                {
                    AudioSource.PlayClipAtPoint(frog, new Vector3(0, 0, 0), 1f);
                }
                //police
                if (hit.collider.CompareTag("police"))
                {
                    AudioSource.PlayClipAtPoint(police, new Vector3(0, 0, 0), 1f);
                }
                //dab
                if (hit.collider.CompareTag("dab"))
                {
                    AudioSource.PlayClipAtPoint(dab, new Vector3(0, 0, 0), 1f);
                }
                //teeth
                if (hit.collider.CompareTag("teeth"))
                {
                    AudioSource.PlayClipAtPoint(teeth, new Vector3(0, 0, 0), 1f);
                }
                //vegetable
                if (hit.collider.CompareTag("vegetable"))
                {
                    AudioSource.PlayClipAtPoint(vegetable, new Vector3(0, 0, 0), 1f);
                }
                //wood
                if (hit.collider.CompareTag("wood"))
                {
                    AudioSource.PlayClipAtPoint(wood, new Vector3(0, 0, 0), 1f);
                }
                //eagle
                if (hit.collider.CompareTag("eagle"))
                {
                    AudioSource.PlayClipAtPoint(eagle, new Vector3(0, 0, 0), 1f);
                }
                //image
                if (hit.collider.CompareTag("image"))
                {
                    AudioSource.PlayClipAtPoint(image, new Vector3(0, 0, 0), 1f);
                }
                //sectors
                if (hit.collider.CompareTag("sectors"))
                {
                    AudioSource.PlayClipAtPoint(sectors, new Vector3(0, 0, 0), 1f);
                }
                //castle
                if (hit.collider.CompareTag("castle"))
                {
                    AudioSource.PlayClipAtPoint(castle, new Vector3(0, 0, 0), 1f);
                }
                //lamp
                if (hit.collider.CompareTag("lamp"))
                {
                    AudioSource.PlayClipAtPoint(lamp, new Vector3(0, 0, 0), 1f);
                }
                //box
                if (hit.collider.CompareTag("box"))
                {
                    AudioSource.PlayClipAtPoint(box, new Vector3(0, 0, 0), 1f);
                }
                //palm
                if (hit.collider.CompareTag("palm"))
                {
                    AudioSource.PlayClipAtPoint(palm, new Vector3(0, 0, 0), 1f);
                }
                //bread
                if (hit.collider.CompareTag("bread"))
                {
                    AudioSource.PlayClipAtPoint(bread, new Vector3(0, 0, 0), 1f);
                }
                //kyar
                if (hit.collider.CompareTag("kyar"))
                {
                    AudioSource.PlayClipAtPoint(kyar, new Vector3(0, 0, 0), 1f);
                }
                //sheep
                if (hit.collider.CompareTag("sheep"))
                {
                    AudioSource.PlayClipAtPoint(sheep, new Vector3(0, 0, 0), 1f);
                }
                //safandi
                if (hit.collider.CompareTag("safandi"))
                {
                    AudioSource.PlayClipAtPoint(safandi, new Vector3(0, 0, 0), 1f);
                }
                //snake
                if (hit.collider.CompareTag("snake"))
                {
                    AudioSource.PlayClipAtPoint(snake, new Vector3(0, 0, 0), 1f);
                }
                //dress
                if (hit.collider.CompareTag("dress"))
                {
                    AudioSource.PlayClipAtPoint(dress, new Vector3(0, 0, 0), 1f);
                }
                //ice
                if (hit.collider.CompareTag("ice"))
                {
                    AudioSource.PlayClipAtPoint(ice, new Vector3(0, 0, 0), 1f);
                }
                //two
                if (hit.collider.CompareTag("two"))
                {
                    AudioSource.PlayClipAtPoint(two, new Vector3(0, 0, 0), 1f);
                }
                //flour
                if (hit.collider.CompareTag("flour"))
                {
                    AudioSource.PlayClipAtPoint(flour, new Vector3(0, 0, 0), 1f);
                }
                //molkhya
                if (hit.collider.CompareTag("molkhya"))
                {
                    AudioSource.PlayClipAtPoint(molkhya, new Vector3(0, 0, 0), 1f);
                }
                //paper
                if (hit.collider.CompareTag("paper"))
                {
                    AudioSource.PlayClipAtPoint(paper, new Vector3(0, 0, 0), 1f);
                }
                //boy
                if (hit.collider.CompareTag("boy"))
                {
                    AudioSource.PlayClipAtPoint(boy, new Vector3(0, 0, 0), 1f);
                }
                //arrow
                if (hit.collider.CompareTag("arrow"))
                {
                    AudioSource.PlayClipAtPoint(arrow, new Vector3(0, 0, 0), 1f);
                }

                //medicne
                if (hit.collider.CompareTag("medicne"))
                {
                    AudioSource.PlayClipAtPoint(medicne, new Vector3(0, 0, 0), 1f);
                }
                //Lamppost
                if (hit.collider.CompareTag("Lamppost"))
                {
                    AudioSource.PlayClipAtPoint(Lamppost, new Vector3(0, 0, 0), 1f);
                }
                //rope
                if (hit.collider.CompareTag("rope"))
                {
                    AudioSource.PlayClipAtPoint(rope, new Vector3(0, 0, 0), 1f);
                }
                //honey
                if (hit.collider.CompareTag("honey"))
                {
                    AudioSource.PlayClipAtPoint(honey, new Vector3(0, 0, 0), 1f);
                }
                //flag
                if (hit.collider.CompareTag("flag"))
                {
                    AudioSource.PlayClipAtPoint(flag, new Vector3(0, 0, 0), 1f);
                }

                //grape
                if (hit.collider.CompareTag("grape"))
                {
                    AudioSource.PlayClipAtPoint(grape, new Vector3(0, 0, 0), 1f);
                }
                //wolf
                if (hit.collider.CompareTag("wolf"))
                {
                    AudioSource.PlayClipAtPoint(wolf, new Vector3(0, 0, 0), 1f);
                }
                //grass
                if (hit.collider.CompareTag("grass"))
                {
                    AudioSource.PlayClipAtPoint(grass, new Vector3(0, 0, 0), 1f);
                }
                //daqn
                if (hit.collider.CompareTag("daqn"))
                {
                    AudioSource.PlayClipAtPoint(daqn, new Vector3(0, 0, 0), 1f);
                }
                //ear
                if (hit.collider.CompareTag("ear"))
                {
                    AudioSource.PlayClipAtPoint(ear, new Vector3(0, 0, 0), 1f);
                }
                //corn
                if (hit.collider.CompareTag("corn"))
                {
                    AudioSource.PlayClipAtPoint(corn, new Vector3(0, 0, 0), 1f);
                }
                //gold
                if (hit.collider.CompareTag("gold"))
                {
                    AudioSource.PlayClipAtPoint(gold, new Vector3(0, 0, 0), 1f);
                }
                //plant
                if (hit.collider.CompareTag("plant"))
                {
                    AudioSource.PlayClipAtPoint(plant, new Vector3(0, 0, 0), 1f);
                }
                //tail
                if (hit.collider.CompareTag("tail"))
                {
                    AudioSource.PlayClipAtPoint(tail, new Vector3(0, 0, 0), 1f);
                }
                //qonfoz
                if (hit.collider.CompareTag("qonfoz"))
                {
                    AudioSource.PlayClipAtPoint(qonfoz, new Vector3(0, 0, 0), 1f);
                }
                //sun
                if (hit.collider.CompareTag("sun"))
                {
                    AudioSource.PlayClipAtPoint(sun, new Vector3(0, 0, 0), 1f);
                }
                //candle
                if (hit.collider.CompareTag("candle"))
                {
                    AudioSource.PlayClipAtPoint(candle, new Vector3(0, 0, 0), 1f);
                }
                //nest
                if (hit.collider.CompareTag("nest"))
                {
                    AudioSource.PlayClipAtPoint(nest, new Vector3(0, 0, 0), 1f);
                }
                //sra3h
                if (hit.collider.CompareTag("sra3h"))
                {
                    AudioSource.PlayClipAtPoint(sra3h, new Vector3(0, 0, 0), 1f);
                }
                //fire
                if (hit.collider.CompareTag("fire"))
                {
                    AudioSource.PlayClipAtPoint(fire, new Vector3(0, 0, 0), 1f);
                }
                //tree
                if (hit.collider.CompareTag("tree"))
                {
                    AudioSource.PlayClipAtPoint(tree, new Vector3(0, 0, 0), 1f);
                }
                //duck
                if (hit.collider.CompareTag("duck"))
                {
                    AudioSource.PlayClipAtPoint(duck, new Vector3(0, 0, 0), 1f);
                }
                //stomach
                if (hit.collider.CompareTag("stomach"))
                {
                    AudioSource.PlayClipAtPoint(stomach, new Vector3(0, 0, 0), 1f);
                }
                //rain
                if (hit.collider.CompareTag("rain"))
                {
                    AudioSource.PlayClipAtPoint(rain, new Vector3(0, 0, 0), 1f);
                }
                //birds
                if (hit.collider.CompareTag("birds"))
                {
                    AudioSource.PlayClipAtPoint(birds, new Vector3(0, 0, 0), 1f);
                }
                //tomato
                if (hit.collider.CompareTag("tomato"))
                {
                    AudioSource.PlayClipAtPoint(tomato, new Vector3(0, 0, 0), 1f);
                }
                //cotton
                if (hit.collider.CompareTag("cotton"))
                {
                    AudioSource.PlayClipAtPoint(cotton, new Vector3(0, 0, 0), 1f);
                }
                //child
                if (hit.collider.CompareTag("child"))
                {
                    AudioSource.PlayClipAtPoint(child, new Vector3(0, 0, 0), 1f);
                }
                //dish
                if (hit.collider.CompareTag("dish"))
                {
                    AudioSource.PlayClipAtPoint(dish, new Vector3(0, 0, 0), 1f);
                }
                //pencil
                if (hit.collider.CompareTag("pencil"))
                {
                    AudioSource.PlayClipAtPoint(pencil, new Vector3(0, 0, 0), 1f);
                }
                //cow
                if (hit.collider.CompareTag("cow"))
                {
                    AudioSource.PlayClipAtPoint(cow, new Vector3(0, 0, 0), 1f);
                }
                //engineer
                if (hit.collider.CompareTag("engineer"))
                {
                    AudioSource.PlayClipAtPoint(engineer, new Vector3(0, 0, 0), 1f);
                }
                //stair
                if (hit.collider.CompareTag("stair"))
                {
                    AudioSource.PlayClipAtPoint(stair, new Vector3(0, 0, 0), 1f);
                }
                //enaa
                if (hit.collider.CompareTag("enaa"))
                {
                    AudioSource.PlayClipAtPoint(enaa, new Vector3(0, 0, 0), 1f);
                }
                //doda
                if (hit.collider.CompareTag("doda"))
                {
                    AudioSource.PlayClipAtPoint(doda, new Vector3(0, 0, 0), 1f);
                }
                //tank
                if (hit.collider.CompareTag("tank"))
                {
                    AudioSource.PlayClipAtPoint(tank, new Vector3(0, 0, 0), 1f);
                }
                //olive
                if (hit.collider.CompareTag("olive"))
                {
                    AudioSource.PlayClipAtPoint(olive, new Vector3(0, 0, 0), 1f);
                }
                //bottle
                if (hit.collider.CompareTag("bottle"))
                {
                    AudioSource.PlayClipAtPoint(bottle, new Vector3(0, 0, 0), 1f);
                }
                //zena
                if (hit.collider.CompareTag("zena"))
                {
                    AudioSource.PlayClipAtPoint(zena, new Vector3(0, 0, 0), 1f);
                }
                //farm
                if (hit.collider.CompareTag("farm"))
                {
                    AudioSource.PlayClipAtPoint(farm, new Vector3(0, 0, 0), 1f);
                }
                //banana
                if (hit.collider.CompareTag("banana"))
                {
                    AudioSource.PlayClipAtPoint(banana, new Vector3(0, 0, 0), 1f);
                }
                //qeraf
                if (hit.collider.CompareTag("qeraf"))
                {
                    AudioSource.PlayClipAtPoint(qeraf, new Vector3(0, 0, 0), 1f);
                }
                //zorar
                if (hit.collider.CompareTag("zorar"))
                {
                    AudioSource.PlayClipAtPoint(zorar, new Vector3(0, 0, 0), 1f);
                }
                //camel
                if (hit.collider.CompareTag("camel"))
                {
                    AudioSource.PlayClipAtPoint(camel, new Vector3(0, 0, 0), 1f);
                }
                //bell
                if (hit.collider.CompareTag("bell"))
                {
                    AudioSource.PlayClipAtPoint(bell, new Vector3(0, 0, 0), 1f);
                }
                //sock
                if (hit.collider.CompareTag("sock"))
                {
                    AudioSource.PlayClipAtPoint(sock, new Vector3(0, 0, 0), 1f);
                }
                //bridge
                if (hit.collider.CompareTag("bridge"))
                {
                    AudioSource.PlayClipAtPoint(bridge, new Vector3(0, 0, 0), 1f);
                }
                //leg
                if (hit.collider.CompareTag("leg"))
                {
                    AudioSource.PlayClipAtPoint(leg, new Vector3(0, 0, 0), 1f);
                }
                //cheese
                if (hit.collider.CompareTag("cheese"))
                {
                    AudioSource.PlayClipAtPoint(cheese, new Vector3(0, 0, 0), 1f);
                }
                //tower
                if (hit.collider.CompareTag("tower"))
                {
                    AudioSource.PlayClipAtPoint(tower, new Vector3(0, 0, 0), 1f);
                }
                //carrot
                if (hit.collider.CompareTag("carrot"))
                {
                    AudioSource.PlayClipAtPoint(carrot, new Vector3(0, 0, 0), 1f);
                }
                //face
                if (hit.collider.CompareTag("face"))
                {
                    AudioSource.PlayClipAtPoint(face, new Vector3(0, 0, 0), 1f);
                }
                //sengab
                if (hit.collider.CompareTag("sengab"))
                {
                    AudioSource.PlayClipAtPoint(sengab, new Vector3(0, 0, 0), 1f);
                }
                //berry
                if (hit.collider.CompareTag("berry"))
                {
                    AudioSource.PlayClipAtPoint(berry, new Vector3(0, 0, 0), 1f);
                }
                //k5tem
                if (hit.collider.CompareTag("5tem"))
                {
                    AudioSource.PlayClipAtPoint(ktem, new Vector3(0, 0, 0), 1f);
                }
                //ink
                if (hit.collider.CompareTag("ink"))
                {
                    AudioSource.PlayClipAtPoint(ink, new Vector3(0, 0, 0), 1f);
                }
                //roman
                if (hit.collider.CompareTag("roman"))
                {
                    AudioSource.PlayClipAtPoint(roman, new Vector3(0, 0, 0), 1f);
                }
                //rabbit
                if (hit.collider.CompareTag("rabbit"))
                {
                    AudioSource.PlayClipAtPoint(rabbit, new Vector3(0, 0, 0), 1f);
                }
                //stone
                if (hit.collider.CompareTag("stone"))
                {
                    AudioSource.PlayClipAtPoint(stone, new Vector3(0, 0, 0), 1f);
                }
                //monkey
                if (hit.collider.CompareTag("monkey"))
                {
                    AudioSource.PlayClipAtPoint(monkey, new Vector3(0, 0, 0), 1f);
                }
                //car
                if (hit.collider.CompareTag("car"))
                {
                    AudioSource.PlayClipAtPoint(car, new Vector3(0, 0, 0), 1f);
                }
                //horse
                if (hit.collider.CompareTag("horse"))
                {
                    AudioSource.PlayClipAtPoint(horse, new Vector3(0, 0, 0), 1f);
                }
                //cloud
                if (hit.collider.CompareTag("cloud"))
                {
                    AudioSource.PlayClipAtPoint(cloud, new Vector3(0, 0, 0), 1f);
                }
                //tortoise
                if (hit.collider.CompareTag("tortoise"))
                {
                    AudioSource.PlayClipAtPoint(tortoise, new Vector3(0, 0, 0), 1f);
                }
                //sharke
                if (hit.collider.CompareTag("sharke"))
                {
                    AudioSource.PlayClipAtPoint(sharke, new Vector3(0, 0, 0), 1f);
                }
                //meat
                if (hit.collider.CompareTag("meat"))
                {
                    AudioSource.PlayClipAtPoint(meat, new Vector3(0, 0, 0), 1f);
                }
                //lemon
                if (hit.collider.CompareTag("lemon"))
                {
                    AudioSource.PlayClipAtPoint(lemon, new Vector3(0, 0, 0), 1f);
                }
                //lsan
                if (hit.collider.CompareTag("lsan"))
                {
                    AudioSource.PlayClipAtPoint(lsan, new Vector3(0, 0, 0), 1f);
                }
                //milk
                if (hit.collider.CompareTag("milk"))
                {
                    AudioSource.PlayClipAtPoint(milk, new Vector3(0, 0, 0), 1f);
                }
                //star
                if (hit.collider.CompareTag("star"))
                {
                    AudioSource.PlayClipAtPoint(star, new Vector3(0, 0, 0), 1f);
                }
                //watermalon
                if (hit.collider.CompareTag("watermalon"))
                {
                    AudioSource.PlayClipAtPoint(watermalon, new Vector3(0, 0, 0), 1f);
                }
                //bee
                if (hit.collider.CompareTag("bee"))
                {
                    AudioSource.PlayClipAtPoint(bee, new Vector3(0, 0, 0), 1f);
                }
                //butterfly
                if (hit.collider.CompareTag("butterfly"))
                {
                    AudioSource.PlayClipAtPoint(butterfly, new Vector3(0, 0, 0), 1f);
                }
                //elephant
                if (hit.collider.CompareTag("elephant"))
                {
                    AudioSource.PlayClipAtPoint(elephant, new Vector3(0, 0, 0), 1f);
                }
                //nose
                if (hit.collider.CompareTag("nose"))
                {
                    AudioSource.PlayClipAtPoint(nose, new Vector3(0, 0, 0), 1f);
                }
                //door
                if (hit.collider.CompareTag("door"))
                {
                    AudioSource.PlayClipAtPoint(door, new Vector3(0, 0, 0), 1f);
                }
                //book
                if (hit.collider.CompareTag("book"))
                {
                    AudioSource.PlayClipAtPoint(book, new Vector3(0, 0, 0), 1f);
                }
                //iron
                if (hit.collider.CompareTag("iron"))
                {
                    AudioSource.PlayClipAtPoint(iron, new Vector3(0, 0, 0), 1f);
                }
                //teacher
                if (hit.collider.CompareTag("teacher"))
                {
                    AudioSource.PlayClipAtPoint(teacher, new Vector3(0, 0, 0), 1f);
                }
                //onion
                if (hit.collider.CompareTag("onion"))
                {
                    AudioSource.PlayClipAtPoint(onion, new Vector3(0, 0, 0), 1f);
                }
                //mishmish
                if (hit.collider.CompareTag("mishmish"))
                {
                    AudioSource.PlayClipAtPoint(mishmish, new Vector3(0, 0, 0), 1f);
                }
                //oktbot
                if (hit.collider.CompareTag("oktbot"))
                {
                    AudioSource.PlayClipAtPoint(oktbot, new Vector3(0, 0, 0), 1f);
                }
                //ras
                if (hit.collider.CompareTag("ras"))
                {
                    AudioSource.PlayClipAtPoint(ras, new Vector3(0, 0, 0), 1f);
                }
                //nail
                if (hit.collider.CompareTag("nail"))
                {
                    AudioSource.PlayClipAtPoint(nail, new Vector3(0, 0, 0), 1f);
                }
                //cup
                if (hit.collider.CompareTag("cup"))
                {
                    AudioSource.PlayClipAtPoint(cup, new Vector3(0, 0, 0), 1f);
                }
                //rat
                if (hit.collider.CompareTag("rat"))
                {
                    AudioSource.PlayClipAtPoint(rat, new Vector3(0, 0, 0), 1f);
                }
                //toy
                if (hit.collider.CompareTag("toy"))
                {
                    AudioSource.PlayClipAtPoint(toy, new Vector3(0, 0, 0), 1f);
                }
                //h
                if (hit.collider.CompareTag("h"))
                {
                    AudioSource.PlayClipAtPoint(h, new Vector3(0, 0, 0), 1f);
                }
                //f
                if (hit.collider.CompareTag("f"))
                {
                    AudioSource.PlayClipAtPoint(f, new Vector3(0, 0, 0), 1f);
                }
                //e
                if (hit.collider.CompareTag("e"))
                {
                    AudioSource.PlayClipAtPoint(e, new Vector3(0, 0, 0), 1f);
                }
                //u
                if (hit.collider.CompareTag("u"))
                {
                    AudioSource.PlayClipAtPoint(u, new Vector3(0, 0, 0), 1f);
                }
                //geem
                if (hit.collider.CompareTag("geem"))
                {
                    AudioSource.PlayClipAtPoint(geem, new Vector3(0, 0, 0), 1f);
                }
                //o
                if (hit.collider.CompareTag("o"))
                {
                    AudioSource.PlayClipAtPoint(o, new Vector3(0, 0, 0), 1f);
                }
                //dal
                if (hit.collider.CompareTag("dal"))
                {
                    AudioSource.PlayClipAtPoint(dal, new Vector3(0, 0, 0), 1f);
                }
                //w
                if (hit.collider.CompareTag("w"))
                {
                    AudioSource.PlayClipAtPoint(w, new Vector3(0, 0, 0), 1f);
                }
                //taa
                if (hit.collider.CompareTag("taa"))
                {
                    AudioSource.PlayClipAtPoint(taa, new Vector3(0, 0, 0), 1f);
                }
                //j
                if (hit.collider.CompareTag("j"))
                {
                    AudioSource.PlayClipAtPoint(j, new Vector3(0, 0, 0), 1f);
                }
                //q
                if (hit.collider.CompareTag("q"))
                {
                    AudioSource.PlayClipAtPoint(q, new Vector3(0, 0, 0), 1f);
                }
                //r
                if (hit.collider.CompareTag("r"))
                {
                    AudioSource.PlayClipAtPoint(r, new Vector3(0, 0, 0), 1f);
                }
                //y
                if (hit.collider.CompareTag("y"))
                {
                    AudioSource.PlayClipAtPoint(y, new Vector3(0, 0, 0), 1f);
                }
                //t
                if (hit.collider.CompareTag("t"))
                {
                    AudioSource.PlayClipAtPoint(t, new Vector3(0, 0, 0), 1f);
                }
                //kaf
                if (hit.collider.CompareTag("kaf"))
                {
                    AudioSource.PlayClipAtPoint(kaf, new Vector3(0, 0, 0), 1f);
                }
                //l
                if (hit.collider.CompareTag("l"))
                {
                    AudioSource.PlayClipAtPoint(l, new Vector3(0, 0, 0), 1f);
                }
                //k
                if (hit.collider.CompareTag("k"))
                {
                    AudioSource.PlayClipAtPoint(k, new Vector3(0, 0, 0), 1f);
                }
                //i
                if (hit.collider.CompareTag("i"))
                {
                    AudioSource.PlayClipAtPoint(i, new Vector3(0, 0, 0), 1f);
                }
                //d
                if (hit.collider.CompareTag("d"))
                {
                    AudioSource.PlayClipAtPoint(d, new Vector3(0, 0, 0), 1f);
                }
                //a
                if (hit.collider.CompareTag("a"))
                {
                    AudioSource.PlayClipAtPoint(a, new Vector3(0, 0, 0), 1f);
                }
                //s
                if (hit.collider.CompareTag("s"))
                {
                    AudioSource.PlayClipAtPoint(s, new Vector3(0, 0, 0), 1f);
                }
                //zal
                if (hit.collider.CompareTag("zal"))
                {
                    AudioSource.PlayClipAtPoint(zal, new Vector3(0, 0, 0), 1f);
                }
                //ro
                if (hit.collider.CompareTag("ro"))
                {
                    AudioSource.PlayClipAtPoint(ro, new Vector3(0, 0, 0), 1f);
                }
                //zo
                if (hit.collider.CompareTag("zo"))
                {
                    AudioSource.PlayClipAtPoint(zo, new Vector3(0, 0, 0), 1f);
                }
                //snara
                if (hit.collider.CompareTag("snara"))
                {
                    AudioSource.PlayClipAtPoint(snara, new Vector3(0, 0, 0), 1f);
                }

                //halak
                if (hit.collider.CompareTag("halak"))
                {
                    AudioSource.PlayClipAtPoint(halak, new Vector3(0, 0, 0), 1f);
                }
                //wheat
                if (hit.collider.CompareTag("wheat"))
                {
                    AudioSource.PlayClipAtPoint(wheat, new Vector3(0, 0, 0), 1f);
                }
                //foot
                if (hit.collider.CompareTag("foot"))
                {
                    AudioSource.PlayClipAtPoint(foot, new Vector3(0, 0, 0), 1f);
                }
                //train
                if (hit.collider.CompareTag("train"))
                {
                    AudioSource.PlayClipAtPoint(train, new Vector3(0, 0, 0), 1f);
                }
                //moga
                if (hit.collider.CompareTag("moga"))
                {
                    AudioSource.PlayClipAtPoint(moga, new Vector3(0, 0, 0), 1f);
                }
                //sarag
                if (hit.collider.CompareTag("sarag"))
                {
                    AudioSource.PlayClipAtPoint(sarag, new Vector3(0, 0, 0), 1f);
                }
                //crown
                if (hit.collider.CompareTag("crown"))
                {
                    AudioSource.PlayClipAtPoint(crown, new Vector3(0, 0, 0), 1f);
                }
                //CROCODIL
                if (hit.collider.CompareTag("CROCODIL"))
                {
                    AudioSource.PlayClipAtPoint(CROCODIL, new Vector3(0, 0, 0), 1f);
                }
                //geraf
                if (hit.collider.CompareTag("geraf"))
                {
                    AudioSource.PlayClipAtPoint(geraf, new Vector3(0, 0, 0), 1f);
                }
                //dab3
                if (hit.collider.CompareTag("dab3"))
                {
                    AudioSource.PlayClipAtPoint(dab3, new Vector3(0, 0, 0), 1f);
                }
                //hand
                if (hit.collider.CompareTag("hand"))
                {
                    AudioSource.PlayClipAtPoint(hand, new Vector3(0, 0, 0), 1f);
                }
                //trainroad
                if (hit.collider.CompareTag("trainroad"))
                {
                    AudioSource.PlayClipAtPoint(trainroad, new Vector3(0, 0, 0), 1f);
                }
                //body
                if (hit.collider.CompareTag("body"))
                {
                    AudioSource.PlayClipAtPoint(body, new Vector3(0, 0, 0), 1f);
                }
                //woow
                if (hit.collider.CompareTag("woow"))
                {
                    AudioSource.PlayClipAtPoint(woow, new Vector3(0, 0, 0), 1f);
                }
                //ballon
                if (hit.collider.CompareTag("ballon"))
                {
                    AudioSource.PlayClipAtPoint(ballon, new Vector3(0, 0, 0), 1f);
                }
                //fanous
                if (hit.collider.CompareTag("fanous"))
                {
                    AudioSource.PlayClipAtPoint(fanous, new Vector3(0, 0, 0), 1f);
                }
                //fagel
                if (hit.collider.CompareTag("fagel"))
                {
                    AudioSource.PlayClipAtPoint(fagel, new Vector3(0, 0, 0), 1f);
                }
                //romey
                if (hit.collider.CompareTag("romey"))
                {
                    AudioSource.PlayClipAtPoint(romey, new Vector3(0, 0, 0), 1f);
                }
                //sabora
                if (hit.collider.CompareTag("sabora"))
                {
                    AudioSource.PlayClipAtPoint(sabora, new Vector3(0, 0, 0), 1f);
                }
                //sugar
                if (hit.collider.CompareTag("sugar"))
                {
                    AudioSource.PlayClipAtPoint(sugar, new Vector3(0, 0, 0), 1f);
                }
                //selsla
                if (hit.collider.CompareTag("selsla"))
                {
                    AudioSource.PlayClipAtPoint(selsla, new Vector3(0, 0, 0), 1f);
                }
                //dra3
                if (hit.collider.CompareTag("dra3"))
                {
                    AudioSource.PlayClipAtPoint(dra3, new Vector3(0, 0, 0), 1f);
                }
                //belt
                if (hit.collider.CompareTag("belt"))
                {
                    AudioSource.PlayClipAtPoint(belt, new Vector3(0, 0, 0), 1f);
                }
                //ard
                if (hit.collider.CompareTag("ard"))
                {
                    AudioSource.PlayClipAtPoint(ard, new Vector3(0, 0, 0), 1f);
                }
                //dall
                if (hit.collider.CompareTag("dall"))
                {
                    AudioSource.PlayClipAtPoint(dall, new Vector3(0, 0, 0), 1f);
                }
                //ras5
                if (hit.collider.CompareTag("ras5"))
                {
                    AudioSource.PlayClipAtPoint(ras5, new Vector3(0, 0, 0), 1f);
                }
                //rock
                if (hit.collider.CompareTag("rock"))
                {
                    AudioSource.PlayClipAtPoint(rock, new Vector3(0, 0, 0), 1f);
                }
                //solider
                if (hit.collider.CompareTag("solider"))
                {
                    AudioSource.PlayClipAtPoint(solider, new Vector3(0, 0, 0), 1f);
                }
                //singer
                if (hit.collider.CompareTag("singer"))
                {
                    AudioSource.PlayClipAtPoint(singer, new Vector3(0, 0, 0), 1f);
                }
                //hoot
                if (hit.collider.CompareTag("hoot"))
                {
                    AudioSource.PlayClipAtPoint(hoot, new Vector3(0, 0, 0), 1f);
                }
            }
        }
    }
}



