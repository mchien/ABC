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
[![The card](http://img.youtube.com/vi/ZvkXtGMBcJ8/0.jpg)](https://www.youtube.com/embed/ZvkXtGMBcJ8)

### Back
[![The back](http://img.youtube.com/vi/3J1Z7eK7Gmk/0.jpg)](https://www.youtube.com/embed/3J1Z7eK7Gmk)

### Switching between scenes
[![The swap](http://img.youtube.com/vi/hWuI6IGQLH8/0.jpg)](https://www.youtube.com/embed/hWuI6IGQLH8)

### Front
[![The front](http://img.youtube.com/vi/QxVzI-48L5s/0.jpg)](https://www.youtube.com/embed/QxVzI-48L5s)
