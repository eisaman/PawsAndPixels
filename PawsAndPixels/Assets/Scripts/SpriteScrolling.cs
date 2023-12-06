using UnityEngine;
using UnityEngine.UI;

public class SpriteScrolling : MonoBehaviour
{
    public Sprite[] petSprites;  // Array of sprites to scroll through
    public Image petImage;       // Image component to display the sprite
    private int currentSpriteIndex = 0;

    void Start()
    {
        DisplayCurrentSprite();
    }

    void DisplayCurrentSprite()
    {
        // Display the current sprite in the Image component
        petImage.sprite = petSprites[currentSpriteIndex];
    }

    public void ScrollRight()
    {
        // Increment the index and display the next sprite
        currentSpriteIndex = (currentSpriteIndex + 1) % petSprites.Length;
        DisplayCurrentSprite();
    }

    public void ScrollLeft()
    {
        // Decrement the index and display the previous sprite
        currentSpriteIndex = (currentSpriteIndex - 1 + petSprites.Length) % petSprites.Length;
        DisplayCurrentSprite();
    }
}
