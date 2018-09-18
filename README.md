# ABC - Augmented Business Card

Purpose:
* educate general people around me (who may or may not be tech savvy) about AR technology
* combine distributable/scalable AR assets to others using. In this case, using a business card
* raise awareness of MEL program that I'm a part of (at the time of writing)
* have users actively/passively help market me and the brand through silly interactions (e.g. waving the business card around)
* learn something about AR programming with Vuforia

# Technologies/Methods

The key methods used/learned for each part of this project

### Camera
* "World center mode" setting

### Ball
* OnCollisionEnter/Exit/Stay/noCollision
* AddForce
* Vector3.Reflect/velocity/angularvelocity
* WorldToViewportPoint
* SetActive vs Destroy

### Paddle
* ignoreCollision
* rotation
** axis restriction to only translate in one place and rotate along z to follow marker

### Scaling
* StartCoroutine
* orthographicSize
**  for aspect ratio

### Scene Change
* OnTrackingFound
** had to override to extend with custom activity
* LoadScene
** takes away from immersion as it fades out and in to load

### Walls
* WorldToViewportPoint/ViewportToWorldPoint
** mapping real device boundaries to virtual walls, so walls are placed against perimeter of device at runtime
* Parent object as _controllers

Estimated total time spent: 3-4 days

# Demo
**All videos below contain no sound**

### The Card
<iframe width="560" height="315" src="https://www.youtube.com/embed/ZvkXtGMBcJ8" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>

### Back
<iframe width="560" height="315" src="https://www.youtube.com/embed/QxVzI-48L5s" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>

### Switching between scenes
<iframe width="560" height="315" src="https://www.youtube.com/embed/3J1Z7eK7Gmk" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>

### Front
<iframe width="560" height="315" src="https://www.youtube.com/embed/hWuI6IGQLH8" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
