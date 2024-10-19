# Ease Function Kit

This implementation provides a simple set of easing functions for various speed modifications in Unity. Easing functions are commonly used in animations to create smooth transitions and control the rate of change over time, allowing for effects like acceleration, deceleration, and oscillation. These native C# implementations are adapted from examples available on [Easings.net](https://easings.net/), a popular resource for visualizing and understanding easing curves. The functions are designed to work seamlessly with Unity’s animation and movement systems, giving developers the ability to easily apply different types of motion, such as linear, quadratic, cubic, and elastic, to their game objects or UI elements. These easing functions are ideal for fine-tuning animations, transitions, and movement behaviors in games or interactive applications.

### Easing Functions

- **InExpo**
- **OutExpo**
- **InOutExpo**
- **InBack**
- **OutBack**
- **InOutBack**
- **InSine**
- **OutSine**
- **InOutSine**
- **InCubic**
- **OutCubic**
- **InOutCubic**
- **InQuint**
- **OutQuint**
- **InOutQuint**
- **InCirc**
- **OutCirc**
- **InOutCirc**
- **InElastic**
- **OutElastic**
- **InOutElastic**
- **InQuad**
- **OutQuad**
- **InOutQuad**
- **InQuart**
- **OutQuart**
- **InOutQuart**

### Example of Usage

```cs
private IEnumerator ScaleProcess()
{
    Vector2 from = transform.localScale;
    Vector2 to = new Vector2(1.25f, 1.25f);
    float t = 0.0f;
    float time = 0.15f;

    while (t < time)
    {
        t += Time.deltaTime;
        // Instead of the dircet value of t / time, we use the output of OutBack function to simulate a more organic acceleration.
        transform.localScale = Vector2.LerpUnclamped(from, to, Ease.OutBack(t / time));
        yield return null;
    }

    transform.localScale = end;
}
```
