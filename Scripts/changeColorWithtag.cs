using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeColorWithtag : MonoBehaviour
{
    Color startingOrange = new Color(1f, 0.13725490196f, 0.09803921568f);
    Color startingPurple = new Color(0.18823529411f, 0.07450980392f, 0.33725490196f);
    Color startingCyan = new Color(0.70588235294f, 0.98431372549f, 0.91372549019f);
    Color startingGrey = new Color(0.86274509803f, 0.86274509803f, 0.86274509803f);
    Color white = new Color(1f, 1f, 1f);


    Color pinkishOrange = new Color(1, 0.54509803921f, 0.47058823529f);
    Color redishPurple = new Color(0.29019607843f, 0.05098039215f, 0.21176470588f);
    Color lightGreen = new Color(0.81961f, 0.749f, 0.47059f);

    Color BGGreen = new Color(0.23137254902f, 0.29803921568f, 0.21568627451f);
    Color PlayerLightGreen = new Color(0.96078431372f, 0.96470588235f, 0.83137254902f);
    Color SliderLightGreen = new Color(0.39607843137f, 0.43921568627f, 0.23529411764f);
    Color lightOrange = new Color(0.39607843137f, 0.43921568627f, 0.23529411764f);

    Color lightPurple = new Color(0.35686274509f, 0.10588235294f, 0.48235294117f);

    Color BGGrey = new Color(0.18431372549f, 0.11764705882f, 0.18039215686f);
    Color PlayerOrange = new Color(0.92549019607f, 0.35294117647f, 0.22352941176f);
    Color Slidergrey = new Color(0.31372549019f, 0.23529411764f, 0.30588235294f);
    Color EnemyYellow = new Color(0.92156862745f, 0.50196078431f, 0.0862745098f);
    Color powerupCyan = new Color(0.48235294117f, 0.70196078431f, 0.59607843137f);

    Color black = new Color(0f, 0f, 0f);
    Color darkGrey = new Color(0.13725490196f, 0.13725490196f, 0.13725490196f);
    Color lightGrey = new Color(0.69411764705f, 0.69411764705f, 0.69411764705f);

    Color lightCyan = new Color(0.66274509803f, 0.83137254902f, 0.71372549019f);
    Color darkCyan = new Color(0.13725490196f, 0.6862745098f, 0.62352941176f);

    Color NavyBlue = new Color(0.16470588235f, 0.18823529411f, 0.26666666666f);
    Color GreenishBlue = new Color(0.25098039215f, 0.6862745098f, 0.62352941176f);
    Color lightBlue = new Color(0.45490196078f, 0.65098039215f, 0.78823529411f);
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartingColor()
    {
        Color1[] colored1 = FindObjectsOfType<Color1>();
        Color2[] colored2 = FindObjectsOfType<Color2>();
        Color3[] colored3 = FindObjectsOfType<Color3>();
        Color4[] colored4 = FindObjectsOfType<Color4>();
        Color5[] colored5 = FindObjectsOfType<Color5>();
        CurrentScoreColor[] textColor = FindObjectsOfType<CurrentScoreColor>();
        BestScoreColor[] bestTextColor = FindObjectsOfType<BestScoreColor>();
        ImageColor[] imageColor = FindObjectsOfType<ImageColor>();
        PlayImage[] playImageColor = FindObjectsOfType<PlayImage>();
        PlayerDeathEffectColor[] playerDeathEffect = FindObjectsOfType<PlayerDeathEffectColor>();
        EnemyDeathEffectColor[] enemyDeathEffect = FindObjectsOfType<EnemyDeathEffectColor>();
        PowerUpEffectColor[] powerupEffect = FindObjectsOfType<PowerUpEffectColor>();


        if (colored1 != null)
        {
            foreach (Color1 color1 in colored1)
            {
                color1.GetComponent<SpriteRenderer>().color = startingOrange;
            }
        }
        if (colored2 != null)
        {
            foreach (Color2 color2 in colored2)
            {
                color2.GetComponent<SpriteRenderer>().color = startingPurple;
            }
        }
        if (colored3 != null)
        {
            foreach (Color3 color3 in colored3)
            {
                color3.GetComponent<SpriteRenderer>().color = white;
            }
        }
        if (colored4 != null)
        {
            foreach (Color4 color4 in colored4)
            {
                color4.GetComponent<SpriteRenderer>().color = startingGrey;
            }
        }
        if (colored5 != null)
        {
            foreach (Color5 color5 in colored5)
            {
                color5.GetComponent<SpriteRenderer>().color = startingCyan;
            }
        }
       
        if (textColor != null)
        {
            foreach (CurrentScoreColor text1 in textColor)
            {
                text1.GetComponent<Text>().color = startingOrange;
            }
        }
        if (bestTextColor != null)
        {
            foreach (BestScoreColor text2 in bestTextColor)
            {
                text2.GetComponent<Text>().color = startingPurple;
            }
        }
        if (imageColor != null)
        {
            foreach (ImageColor image2 in imageColor)
            {
                image2.GetComponent<Image>().color = startingPurple;
            }
        }
        if (playImageColor != null)
        {
            foreach (PlayImage image3 in playImageColor)
            {
                image3.GetComponent<Image>().color = white;
            }
        }
        if (enemyDeathEffect != null)
        {
            foreach (EnemyDeathEffectColor enemy2 in enemyDeathEffect)
            {
                enemy2.GetComponent<ParticleSystem>().startColor = startingPurple;
            }
        }
        if (playerDeathEffect != null)
        {
            foreach (PlayerDeathEffectColor player1 in playerDeathEffect)
            {
                player1.GetComponent<ParticleSystem>().startColor = startingOrange;
            }
        }
        if (powerupEffect != null)
        {
            foreach (PowerUpEffectColor power5 in powerupEffect)
            {
                power5.GetComponent<ParticleSystem>().startColor = startingCyan;
            }
        }

    }





    public void ChangeColorAtFivePoints()
    {
        Color1[] colored1 = FindObjectsOfType<Color1>();
        Color2[] colored2 = FindObjectsOfType<Color2>();
        Color3[] colored3 = FindObjectsOfType<Color3>();
        Color4[] colored4 = FindObjectsOfType<Color4>();
        Color5[] colored5 = FindObjectsOfType<Color5>();
        PlayImage[] playImageColor = FindObjectsOfType<PlayImage>();
        CurrentScoreColor[] textColor = FindObjectsOfType<CurrentScoreColor>();
        BestScoreColor[] bestTextColor = FindObjectsOfType<BestScoreColor>();
        ImageColor[] imageColor = FindObjectsOfType<ImageColor>();
        PlayerDeathEffectColor[] playerDeathEffect = FindObjectsOfType<PlayerDeathEffectColor>();
        EnemyDeathEffectColor[] enemyDeathEffect = FindObjectsOfType<EnemyDeathEffectColor>();
        PowerUpEffectColor[] powerupEffect = FindObjectsOfType<PowerUpEffectColor>();

        if (playImageColor != null)
        {
            foreach (PlayImage image3 in playImageColor)
            {
                image3.GetComponent<Image>().color = white;
            }
        }
        if (colored4 != null)
        {
            foreach (Color4 color4 in colored4)
            {
                color4.GetComponent<SpriteRenderer>().color = startingGrey;
            }
        }
        if (colored3 != null)
        {
            foreach (Color3 color3 in colored3)
            {
                color3.GetComponent<SpriteRenderer>().color = white;
            }
        }
        if (colored1 != null)
        {
            foreach (Color1 color1 in colored1)
            {
                color1.GetComponent<SpriteRenderer>().color = lightGreen;
            }
        }
        if (colored2 != null)
        {
            foreach (Color2 color2 in colored2)
            {
                color2.GetComponent<SpriteRenderer>().color = redishPurple;
            }
        }
        if (colored5 != null)
        {
            foreach (Color5 color5 in colored5)
            {
                color5.GetComponent<SpriteRenderer>().color = pinkishOrange;
            }
        }
        if (textColor != null)
        {
            foreach (CurrentScoreColor text1 in textColor)
            {
                text1.GetComponent<Text>().color = lightGreen;
            }
        }
        if (bestTextColor != null)
        {
            foreach (BestScoreColor text2 in bestTextColor)
            {
                text2.GetComponent<Text>().color = redishPurple;
            }
        }
        if (imageColor != null)
        {
            foreach (ImageColor image2 in imageColor)
            {
                image2.GetComponent<Image>().color = redishPurple;
            }
        }
        if (enemyDeathEffect != null)
        {
            foreach (EnemyDeathEffectColor enemy2 in enemyDeathEffect)
            {
                enemy2.GetComponent<ParticleSystem>().startColor = redishPurple;
            }
        }
        if (playerDeathEffect != null)
        {
            foreach (PlayerDeathEffectColor player1 in playerDeathEffect)
            {
                player1.GetComponent<ParticleSystem>().startColor = lightGreen;
            }
        }
        if (powerupEffect != null)
        {
            foreach (PowerUpEffectColor power5 in powerupEffect)
            {
                power5.GetComponent<ParticleSystem>().startColor = pinkishOrange;
            }
        }


    }
    public void ChangeColorAtTenPoints()
    {
        Color1[] colored1 = FindObjectsOfType<Color1>();
        Color2[] colored2 = FindObjectsOfType<Color2>();
        Color3[] colored3 = FindObjectsOfType<Color3>();
        Color4[] colored4 = FindObjectsOfType<Color4>();
        Color5[] colored5 = FindObjectsOfType<Color5>();
        CurrentScoreColor[] textColor = FindObjectsOfType<CurrentScoreColor>();
        BestScoreColor[] bestTextColor = FindObjectsOfType<BestScoreColor>();
        ImageColor[] imageColor = FindObjectsOfType<ImageColor>();
        PlayImage[] playImageColor = FindObjectsOfType<PlayImage>();
        PlayerDeathEffectColor[] playerDeathEffect = FindObjectsOfType<PlayerDeathEffectColor>();
        EnemyDeathEffectColor[] enemyDeathEffect = FindObjectsOfType<EnemyDeathEffectColor>();
        PowerUpEffectColor[] powerupEffect = FindObjectsOfType<PowerUpEffectColor>();

        if (colored1 != null)
        {
            foreach (Color1 color1 in colored1)
            {
                color1.GetComponent<SpriteRenderer>().color = PlayerLightGreen;
            }
        }
        if (colored2 != null)
        {
            foreach (Color2 color2 in colored2)
            {
                color2.GetComponent<SpriteRenderer>().color = PlayerLightGreen;
            }
        }
        if (colored4 != null)
        {
            foreach (Color4 color4 in colored4)
            {
                color4.GetComponent<SpriteRenderer>().color = SliderLightGreen;
            }
        }
        if (colored5 != null)
        {
            foreach (Color5 color5 in colored5)
            {
                color5.GetComponent<SpriteRenderer>().color = pinkishOrange;
            }
        }
        if (textColor != null)
        {
            foreach (CurrentScoreColor text1 in textColor)
            {
                text1.GetComponent<Text>().color = PlayerLightGreen;
            }
        }
        if (bestTextColor != null)
        {
            foreach (BestScoreColor text2 in bestTextColor)
            {
                text2.GetComponent<Text>().color = SliderLightGreen;
            }
        }
        if (imageColor != null)
        {
            foreach (ImageColor image2 in imageColor)
            {
                image2.GetComponent<Image>().color = PlayerLightGreen;
            }
        }
        if (colored3 != null)
        {
            foreach (Color3 color3 in colored3)
            {
                color3.GetComponent<SpriteRenderer>().color = BGGreen;
            }
        }
        if (playImageColor != null)
        {
            foreach (PlayImage image3 in playImageColor)
            {
                image3.GetComponent<Image>().color = BGGreen;
            }
        }
        if (enemyDeathEffect != null)
        {
            foreach (EnemyDeathEffectColor enemy2 in enemyDeathEffect)
            {
                enemy2.GetComponent<ParticleSystem>().startColor = PlayerLightGreen;
            }
        }
        if (playerDeathEffect != null)
        {
            foreach (PlayerDeathEffectColor player1 in playerDeathEffect)
            {
                player1.GetComponent<ParticleSystem>().startColor = PlayerLightGreen;
            }
        }
        if (powerupEffect != null)
        {
            foreach (PowerUpEffectColor power5 in powerupEffect)
            {
                power5.GetComponent<ParticleSystem>().startColor = pinkishOrange;
            }
        }
    }
    public void ChangeColorAtFifteenPoints()
    {
        Color1[] colored1 = FindObjectsOfType<Color1>();
        Color2[] colored2 = FindObjectsOfType<Color2>();
        Color3[] colored3 = FindObjectsOfType<Color3>();
        Color4[] colored4 = FindObjectsOfType<Color4>();
        Color5[] colored5 = FindObjectsOfType<Color5>();
        CurrentScoreColor[] textColor = FindObjectsOfType<CurrentScoreColor>();
        BestScoreColor[] bestTextColor = FindObjectsOfType<BestScoreColor>();
        ImageColor[] imageColor = FindObjectsOfType<ImageColor>();
        PlayImage[] playImageColor = FindObjectsOfType<PlayImage>();
        PlayerDeathEffectColor[] playerDeathEffect = FindObjectsOfType<PlayerDeathEffectColor>();
        EnemyDeathEffectColor[] enemyDeathEffect = FindObjectsOfType<EnemyDeathEffectColor>();
        PowerUpEffectColor[] powerupEffect = FindObjectsOfType<PowerUpEffectColor>();

        if (colored1 != null)
        {
            foreach (Color1 color1 in colored1)
            {
                color1.GetComponent<SpriteRenderer>().color = white;
            }
        }
        if (colored2 != null)
        {
            foreach (Color2 color2 in colored2)
            {
                color2.GetComponent<SpriteRenderer>().color = white;
            }
        }
        if (colored4 != null)
        {
            foreach (Color4 color4 in colored4)
            {
                color4.GetComponent<SpriteRenderer>().color = lightPurple;
            }
        }
        if (colored5 != null)
        {
            foreach (Color5 color5 in colored5)
            {
                color5.GetComponent<SpriteRenderer>().color = startingCyan;
            }
        }
        if (textColor != null)
        {
            foreach (CurrentScoreColor text1 in textColor)
            {
                text1.GetComponent<Text>().color = pinkishOrange;
            }
        }
        if (bestTextColor != null)
        {
            foreach (BestScoreColor text2 in bestTextColor)
            {
                text2.GetComponent<Text>().color = startingCyan;
            }
        }
        if (imageColor != null)
        {
            foreach (ImageColor image2 in imageColor)
            {
                image2.GetComponent<Image>().color = white;
            }
        }
        if (colored3 != null)
        {
            foreach (Color3 color3 in colored3)
            {
                color3.GetComponent<SpriteRenderer>().color = startingPurple;
            }
        }
        if (playImageColor != null)
        {
            foreach (PlayImage image3 in playImageColor)
            {
                image3.GetComponent<Image>().color = startingPurple;
            }
        }
        if (enemyDeathEffect != null)
        {
            foreach (EnemyDeathEffectColor enemy2 in enemyDeathEffect)
            {
                enemy2.GetComponent<ParticleSystem>().startColor = white;
            }
        }
        if (playerDeathEffect != null)
        {
            foreach (PlayerDeathEffectColor player1 in playerDeathEffect)
            {
                player1.GetComponent<ParticleSystem>().startColor = white;
            }
        }
        if (powerupEffect != null)
        {
            foreach (PowerUpEffectColor power5 in powerupEffect)
            {
                power5.GetComponent<ParticleSystem>().startColor = startingCyan;
            }
        }
    }
    public void ChangeColorAtTwentyPoints()
    {
        Color1[] colored1 = FindObjectsOfType<Color1>();
        Color2[] colored2 = FindObjectsOfType<Color2>();
        Color3[] colored3 = FindObjectsOfType<Color3>();
        Color4[] colored4 = FindObjectsOfType<Color4>();
        Color5[] colored5 = FindObjectsOfType<Color5>();
        CurrentScoreColor[] textColor = FindObjectsOfType<CurrentScoreColor>();
        BestScoreColor[] bestTextColor = FindObjectsOfType<BestScoreColor>();
        ImageColor[] imageColor = FindObjectsOfType<ImageColor>();
        PlayImage[] playImageColor = FindObjectsOfType<PlayImage>();
        PlayerDeathEffectColor[] playerDeathEffect = FindObjectsOfType<PlayerDeathEffectColor>();
        EnemyDeathEffectColor[] enemyDeathEffect = FindObjectsOfType<EnemyDeathEffectColor>();
        PowerUpEffectColor[] powerupEffect = FindObjectsOfType<PowerUpEffectColor>();

        if (colored1 != null)
        {
            foreach (Color1 color1 in colored1)
            {
                color1.GetComponent<SpriteRenderer>().color = PlayerOrange;
            }
        }
        if (colored2 != null)
        {
            foreach (Color2 color2 in colored2)
            {
                color2.GetComponent<SpriteRenderer>().color = EnemyYellow;
            }
        }
        if (colored4 != null)
        {
            foreach (Color4 color4 in colored4)
            {
                color4.GetComponent<SpriteRenderer>().color = Slidergrey;
            }
        }
        if (colored5 != null)
        {
            foreach (Color5 color5 in colored5)
            {
                color5.GetComponent<SpriteRenderer>().color = powerupCyan;
            }
        }
        if (textColor != null)
        {
            foreach (CurrentScoreColor text1 in textColor)
            {
                text1.GetComponent<Text>().color = PlayerOrange;
            }
        }
        if (bestTextColor != null)
        {
            foreach (BestScoreColor text2 in bestTextColor)
            {
                text2.GetComponent<Text>().color = powerupCyan;
            }
        }
        if (imageColor != null)
        {
            foreach (ImageColor image2 in imageColor)
            {
                image2.GetComponent<Image>().color = EnemyYellow;
            }
        }
        if (colored3 != null)
        {
            foreach (Color3 color3 in colored3)
            {
                color3.GetComponent<SpriteRenderer>().color = BGGrey;
            }
        }
        if (playImageColor != null)
        {
            foreach (PlayImage image3 in playImageColor)
            {
                image3.GetComponent<Image>().color = BGGrey;
            }
        }
        if (enemyDeathEffect != null)
        {
            foreach (EnemyDeathEffectColor enemy2 in enemyDeathEffect)
            {
                enemy2.GetComponent<ParticleSystem>().startColor = EnemyYellow;
            }
        }
        if (playerDeathEffect != null)
        {
            foreach (PlayerDeathEffectColor player1 in playerDeathEffect)
            {
                player1.GetComponent<ParticleSystem>().startColor = PlayerOrange;
            }
        }
        if (powerupEffect != null)
        {
            foreach (PowerUpEffectColor power5 in powerupEffect)
            {
                power5.GetComponent<ParticleSystem>().startColor = powerupCyan;
            }
        }
    }
    public void ChangeColorAtTwentyFivePoints()
    {
        Color1[] colored1 = FindObjectsOfType<Color1>();
        Color2[] colored2 = FindObjectsOfType<Color2>();
        Color3[] colored3 = FindObjectsOfType<Color3>();
        Color4[] colored4 = FindObjectsOfType<Color4>();
        Color5[] colored5 = FindObjectsOfType<Color5>();
        CurrentScoreColor[] textColor = FindObjectsOfType<CurrentScoreColor>();
        BestScoreColor[] bestTextColor = FindObjectsOfType<BestScoreColor>();
        ImageColor[] imageColor = FindObjectsOfType<ImageColor>();
        PlayImage[] playImageColor = FindObjectsOfType<PlayImage>();
        PlayerDeathEffectColor[] playerDeathEffect = FindObjectsOfType<PlayerDeathEffectColor>();
        EnemyDeathEffectColor[] enemyDeathEffect = FindObjectsOfType<EnemyDeathEffectColor>();
        PowerUpEffectColor[] powerupEffect = FindObjectsOfType<PowerUpEffectColor>();

        if (colored1 != null)
        {
            foreach (Color1 color1 in colored1)
            {
                color1.GetComponent<SpriteRenderer>().color = white;
            }
        }
        if (colored2 != null)
        {
            foreach (Color2 color2 in colored2)
            {
                color2.GetComponent<SpriteRenderer>().color = white;
            }
        }
        if (colored4 != null)
        {
            foreach (Color4 color4 in colored4)
            {
                color4.GetComponent<SpriteRenderer>().color = black;
            }
        }
        if (colored5 != null)
        {
            foreach (Color5 color5 in colored5)
            {
                color5.GetComponent<SpriteRenderer>().color = black;
            }
        }
        if (textColor != null)
        {
            foreach (CurrentScoreColor text1 in textColor)
            {
                text1.GetComponent<Text>().color = white;
            }
        }
        if (bestTextColor != null)
        {
            foreach (BestScoreColor text2 in bestTextColor)
            {
                text2.GetComponent<Text>().color = white;
            }
        }
        if (imageColor != null)
        {
            foreach (ImageColor image2 in imageColor)
            {
                image2.GetComponent<Image>().color = white;
            }
        }
        if (colored3 != null)
        {
            foreach (Color3 color3 in colored3)
            {
                color3.GetComponent<SpriteRenderer>().color = darkGrey;
            }
        }
        if (playImageColor != null)
        {
            foreach (PlayImage image3 in playImageColor)
            {
                image3.GetComponent<Image>().color = darkGrey;
            }
        }
        if (enemyDeathEffect != null)
        {
            foreach (EnemyDeathEffectColor enemy2 in enemyDeathEffect)
            {
                enemy2.GetComponent<ParticleSystem>().startColor = white;
            }
        }
        if (playerDeathEffect != null)
        {
            foreach (PlayerDeathEffectColor player1 in playerDeathEffect)
            {
                player1.GetComponent<ParticleSystem>().startColor = white;
            }
        }
        if (powerupEffect != null)
        {
            foreach (PowerUpEffectColor power5 in powerupEffect)
            {
                power5.GetComponent<ParticleSystem>().startColor = white;
            }
        }
    }
    public void ChangeColorAtThirtyPoints()
    {
        Color1[] colored1 = FindObjectsOfType<Color1>();
        Color2[] colored2 = FindObjectsOfType<Color2>();
        Color3[] colored3 = FindObjectsOfType<Color3>();
        Color4[] colored4 = FindObjectsOfType<Color4>();
        Color5[] colored5 = FindObjectsOfType<Color5>();
        CurrentScoreColor[] textColor = FindObjectsOfType<CurrentScoreColor>();
        BestScoreColor[] bestTextColor = FindObjectsOfType<BestScoreColor>();
        ImageColor[] imageColor = FindObjectsOfType<ImageColor>();
        PlayImage[] playImageColor = FindObjectsOfType<PlayImage>();
        PlayerDeathEffectColor[] playerDeathEffect = FindObjectsOfType<PlayerDeathEffectColor>();
        EnemyDeathEffectColor[] enemyDeathEffect = FindObjectsOfType<EnemyDeathEffectColor>();
        PowerUpEffectColor[] powerupEffect = FindObjectsOfType<PowerUpEffectColor>();

        if (colored1 != null)
        {
            foreach (Color1 color1 in colored1)
            {
                color1.GetComponent<SpriteRenderer>().color = lightCyan;
            }
        }
        if (colored2 != null)
        {
            foreach (Color2 color2 in colored2)
            {
                color2.GetComponent<SpriteRenderer>().color = PlayerOrange;
            }
        }
        if (colored4 != null)
        {
            foreach (Color4 color4 in colored4)
            {
                color4.GetComponent<SpriteRenderer>().color = startingGrey;
            }
        }
        if (colored5 != null)
        {
            foreach (Color5 color5 in colored5)
            {
                color5.GetComponent<SpriteRenderer>().color = darkCyan;
            }
        }
        if (textColor != null)
        {
            foreach (CurrentScoreColor text1 in textColor)
            {
                text1.GetComponent<Text>().color = lightCyan;
            }
        }
        if (bestTextColor != null)
        {
            foreach (BestScoreColor text2 in bestTextColor)
            {
                text2.GetComponent<Text>().color = darkCyan;
            }
        }
        if (imageColor != null)
        {
            foreach (ImageColor image2 in imageColor)
            {
                image2.GetComponent<Image>().color = PlayerOrange;
            }
        }
        if (colored3 != null)
        {
            foreach (Color3 color3 in colored3)
            {
                color3.GetComponent<SpriteRenderer>().color = white;
            }
        }
        if (playImageColor != null)
        {
            foreach (PlayImage image3 in playImageColor)
            {
                image3.GetComponent<Image>().color = white;
            }
        }
        if (enemyDeathEffect != null)
        {
            foreach (EnemyDeathEffectColor enemy2 in enemyDeathEffect)
            {
                enemy2.GetComponent<ParticleSystem>().startColor = PlayerOrange;
            }
        }
        if (playerDeathEffect != null)
        {
            foreach (PlayerDeathEffectColor player1 in playerDeathEffect)
            {
                player1.GetComponent<ParticleSystem>().startColor = lightCyan;
            }
        }
        if (powerupEffect != null)
        {
            foreach (PowerUpEffectColor power5 in powerupEffect)
            {
                power5.GetComponent<ParticleSystem>().startColor = darkCyan;
            }
        }
    }
    public void ChangeColorAtThirtyFivePoints()
    {
        Color1[] colored1 = FindObjectsOfType<Color1>();
        Color2[] colored2 = FindObjectsOfType<Color2>();
        Color3[] colored3 = FindObjectsOfType<Color3>();
        Color4[] colored4 = FindObjectsOfType<Color4>();
        Color5[] colored5 = FindObjectsOfType<Color5>();
        CurrentScoreColor[] textColor = FindObjectsOfType<CurrentScoreColor>();
        BestScoreColor[] bestTextColor = FindObjectsOfType<BestScoreColor>();
        ImageColor[] imageColor = FindObjectsOfType<ImageColor>();
        PlayImage[] playImageColor = FindObjectsOfType<PlayImage>();
        PlayerDeathEffectColor[] playerDeathEffect = FindObjectsOfType<PlayerDeathEffectColor>();
        EnemyDeathEffectColor[] enemyDeathEffect = FindObjectsOfType<EnemyDeathEffectColor>();
        PowerUpEffectColor[] powerupEffect = FindObjectsOfType<PowerUpEffectColor>();

        if (colored1 != null)
        {
            foreach (Color1 color1 in colored1)
            {
                color1.GetComponent<SpriteRenderer>().color = black;
            }
        }
        if (colored2 != null)
        {
            foreach (Color2 color2 in colored2)
            {
                color2.GetComponent<SpriteRenderer>().color = black;
            }
        }
        if (colored4 != null)
        {
            foreach (Color4 color4 in colored4)
            {
                color4.GetComponent<SpriteRenderer>().color = startingGrey;
            }
        }
        if (colored5 != null)
        {
            foreach (Color5 color5 in colored5)
            {
                color5.GetComponent<SpriteRenderer>().color = startingGrey;
            }
        }
        if (textColor != null)
        {
            foreach (CurrentScoreColor text1 in textColor)
            {
                text1.GetComponent<Text>().color = black;
            }
        }
        if (bestTextColor != null)
        {
            foreach (BestScoreColor text2 in bestTextColor)
            {
                text2.GetComponent<Text>().color = startingGrey;
            }
        }
        if (imageColor != null)
        {
            foreach (ImageColor image2 in imageColor)
            {
                image2.GetComponent<Image>().color = black;
            }
        }
        if (colored3 != null)
        {
            foreach (Color3 color3 in colored3)
            {
                color3.GetComponent<SpriteRenderer>().color = white;
            }
        }
        if (playImageColor != null)
        {
            foreach (PlayImage image3 in playImageColor)
            {
                image3.GetComponent<Image>().color = white;
            }
        }
        if (enemyDeathEffect != null)
        {
            foreach (EnemyDeathEffectColor enemy2 in enemyDeathEffect)
            {
                enemy2.GetComponent<ParticleSystem>().startColor = black;
            }
        }
        if (playerDeathEffect != null)
        {
            foreach (PlayerDeathEffectColor player1 in playerDeathEffect)
            {
                player1.GetComponent<ParticleSystem>().startColor = black;
            }
        }
        if (powerupEffect != null)
        {
            foreach (PowerUpEffectColor power5 in powerupEffect)
            {
                power5.GetComponent<ParticleSystem>().startColor = startingGrey;
            }
        }
    }
    public void ChangeColorAtFourtyPoints()
    {
        Color1[] colored1 = FindObjectsOfType<Color1>();
        Color2[] colored2 = FindObjectsOfType<Color2>();
        Color3[] colored3 = FindObjectsOfType<Color3>();
        Color4[] colored4 = FindObjectsOfType<Color4>();
        Color5[] colored5 = FindObjectsOfType<Color5>();
        CurrentScoreColor[] textColor = FindObjectsOfType<CurrentScoreColor>();
        BestScoreColor[] bestTextColor = FindObjectsOfType<BestScoreColor>();
        ImageColor[] imageColor = FindObjectsOfType<ImageColor>();
        PlayImage[] playImageColor = FindObjectsOfType<PlayImage>();
        PlayerDeathEffectColor[] playerDeathEffect = FindObjectsOfType<PlayerDeathEffectColor>();
        EnemyDeathEffectColor[] enemyDeathEffect = FindObjectsOfType<EnemyDeathEffectColor>();
        PowerUpEffectColor[] powerupEffect = FindObjectsOfType<PowerUpEffectColor>();

        if (colored1 != null)
        {
            foreach (Color1 color1 in colored1)
            {
                color1.GetComponent<SpriteRenderer>().color = GreenishBlue;
            }
        }
        if (colored2 != null)
        {
            foreach (Color2 color2 in colored2)
            {
                color2.GetComponent<SpriteRenderer>().color = PlayerOrange;
            }
        }
        if (colored4 != null)
        {
            foreach (Color4 color4 in colored4)
            {
                color4.GetComponent<SpriteRenderer>().color = startingGrey;
            }
        }
        if (colored5 != null)
        {
            foreach (Color5 color5 in colored5)
            {
                color5.GetComponent<SpriteRenderer>().color = lightBlue;
            }
        }
        if (textColor != null)
        {
            foreach (CurrentScoreColor text1 in textColor)
            {
                text1.GetComponent<Text>().color = GreenishBlue;
            }
        }
        if (bestTextColor != null)
        {
            foreach (BestScoreColor text2 in bestTextColor)
            {
                text2.GetComponent<Text>().color = PlayerOrange;
            }
        }
        if (imageColor != null)
        {
            foreach (ImageColor image2 in imageColor)
            {
                image2.GetComponent<Image>().color = lightBlue;
            }
        }
        if (colored3 != null)
        {
            foreach (Color3 color3 in colored3)
            {
                color3.GetComponent<SpriteRenderer>().color = white;
            }
        }
        if (playImageColor != null)
        {
            foreach (PlayImage image3 in playImageColor)
            {
                image3.GetComponent<Image>().color = white;
            }
        }
        if (enemyDeathEffect != null)
        {
            foreach (EnemyDeathEffectColor enemy2 in enemyDeathEffect)
            {
                enemy2.GetComponent<ParticleSystem>().startColor = PlayerOrange;
            }
        }
        if (playerDeathEffect != null)
        {
            foreach (PlayerDeathEffectColor player1 in playerDeathEffect)
            {
                player1.GetComponent<ParticleSystem>().startColor = GreenishBlue;
            }
        }
        if (powerupEffect != null)
        {
            foreach (PowerUpEffectColor power5 in powerupEffect)
            {
                power5.GetComponent<ParticleSystem>().startColor = lightBlue;
            }
        }
    }
    public void ChangeColorAtFourtyFivePoints()
    {
        Color1[] colored1 = FindObjectsOfType<Color1>();
        Color2[] colored2 = FindObjectsOfType<Color2>();
        Color3[] colored3 = FindObjectsOfType<Color3>();
        Color4[] colored4 = FindObjectsOfType<Color4>();
        Color5[] colored5 = FindObjectsOfType<Color5>();
        CurrentScoreColor[] textColor = FindObjectsOfType<CurrentScoreColor>();
        BestScoreColor[] bestTextColor = FindObjectsOfType<BestScoreColor>();
        ImageColor[] imageColor = FindObjectsOfType<ImageColor>();
        PlayImage[] playImageColor = FindObjectsOfType<PlayImage>();
        PlayerDeathEffectColor[] playerDeathEffect = FindObjectsOfType<PlayerDeathEffectColor>();
        EnemyDeathEffectColor[] enemyDeathEffect = FindObjectsOfType<EnemyDeathEffectColor>();
        PowerUpEffectColor[] powerupEffect = FindObjectsOfType<PowerUpEffectColor>();

        if (colored1 != null)
        {
            foreach (Color1 color1 in colored1)
            {
                color1.GetComponent<SpriteRenderer>().color = PlayerOrange;
            }
        }
        if (colored2 != null)
        {
            foreach (Color2 color2 in colored2)
            {
                color2.GetComponent<SpriteRenderer>().color = GreenishBlue;
            }
        }
        if (colored4 != null)
        {
            foreach (Color4 color4 in colored4)
            {
                color4.GetComponent<SpriteRenderer>().color = darkGrey;
            }
        }
        if (colored5 != null)
        {
            foreach (Color5 color5 in colored5)
            {
                color5.GetComponent<SpriteRenderer>().color = white;
            }
        }
        if (textColor != null)
        {
            foreach (CurrentScoreColor text1 in textColor)
            {
                text1.GetComponent<Text>().color = PlayerOrange;
            }
        }
        if (bestTextColor != null)
        {
            foreach (BestScoreColor text2 in bestTextColor)
            {
                text2.GetComponent<Text>().color = GreenishBlue;
            }
        }
        if (imageColor != null)
        {
            foreach (ImageColor image2 in imageColor)
            {
                image2.GetComponent<Image>().color = white;
            }
        }
        if (colored3 != null)
        {
            foreach (Color3 color3 in colored3)
            {
                color3.GetComponent<SpriteRenderer>().color = NavyBlue;
            }
        }
        if (playImageColor != null)
        {
            foreach (PlayImage image3 in playImageColor)
            {
                image3.GetComponent<Image>().color = NavyBlue;
            }
        }
        if (enemyDeathEffect != null)
        {
            foreach (EnemyDeathEffectColor enemy2 in enemyDeathEffect)
            {
                enemy2.GetComponent<ParticleSystem>().startColor = GreenishBlue;
            }
        }
        if (playerDeathEffect != null)
        {
            foreach (PlayerDeathEffectColor player1 in playerDeathEffect)
            {
                player1.GetComponent<ParticleSystem>().startColor = PlayerOrange;
            }
        }
        if (powerupEffect != null)
        {
            foreach (PowerUpEffectColor power5 in powerupEffect)
            {
                power5.GetComponent<ParticleSystem>().startColor = white;
            }
        }
    }
}
