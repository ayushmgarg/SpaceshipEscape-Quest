# Spaceship Escape

A VR game where you explore a spaceship and collect treasures, and solve certain tasks to save the ship from asteroids and steer it into a safe wormhole.


## What's In This Game

- A spaceship environment you can walk around in
- Treasures scattered around to collect
- VR movement (teleport or smooth locomotion)
- Hand controllers that show up in VR
- Interactive objects 

## The Problem

**The grab system doesn't work properly.** I can see the treasures and objects, but picking them up is completely broken. Everything else mostly works - moving around, looking at stuff, teleporting - but the core mechanic (grabbing things) is busted.

## What I Used

- Unity 6000.0.61f1
- XR Interaction Toolkit 3.0.8
- OpenXR
- Meta Quest 2

## How to Run It

### What You Need
- Unity Hub and Unity 2022.3+
- Android Build Support (install through Unity Hub)
- Meta Quest 2 with Developer Mode on
- USB-C cable (or Air Link if you have that set up)

### Steps

**1. Get the project**
```bash
git clone https://github.com/yourusername/SpaceshipEscape-Quest.git
```

**2. Open it**
- Open Unity Hub
- Click "Add" and find the project folder
- Double click to open (takes a minute first time)

**3. Let Unity install packages**
- Should auto-install XR Interaction Toolkit, OpenXR, etc.
- If it doesn't, go to Window → Package Manager and install them manually

**4. Switch to Android**
- File → Build Settings
- Click Android, then "Switch Platform"
- This takes a few minutes

**5. Setup XR stuff**
- Edit → Project Settings → XR Plug-in Management
- Click the Android tab
- Check "OpenXR"
- If you see warnings, click "Fix All"

**6. Add Quest controller support**
- Project Settings → XR Plug-in Management → OpenXR (still on Android tab)
- Under "Interaction Profiles" click the + button
- Add "Oculus Touch Controller Profile"
- Under "Feature Groups" enable "Meta Quest Support"

**7. Fix graphics settings**
- Project Settings → Player → Android tab
- Find "Graphics APIs" under Other Settings
- Remove Vulkan if it's there (click it, press minus)
- Should just have OpenGLES3

**8. Connect Quest 2**
- Plug in with USB-C cable
- Put headset on
- Allow USB debugging (check "always allow")

**9. Build it**
- File → Build Settings
- Click "Build and Run"
- Pick where to save it
- Wait for it to build and install
- Game should start in your headset

### Quick Testing (If You Have Link)
- Connect Quest via Link or Air Link
- Just press Play in Unity
- Faster for testing but might lag more

## Video Demo

<video src="./my_video_comp.mp4" width="600" controls>A video demonstration of the Spaceship Escape VR game</video>

You can see the spaceship, the movement, and the treasures. You'll also see why I can't actually grab anything lol.

## What Works
- ✅ Walking/teleporting around
- ✅ Head tracking and looking around  
- ✅ Controllers appear in VR
- ✅ Environment and level design
- ✅ Treasures are placed in the scene


## What I Learned

This was my first real VR project. I learned:
- How to set up a Unity VR project from nothing
- XR Interaction Toolkit basics
- Building to Quest 2
- VR locomotion systems
- That version differences matter A LOT in Unity
- Debugging VR is way harder than regular games


## Files Structure
```
SpaceshipEscape-Quest/
├── Assets/           # All game assets, scripts, scenes
├── Packages/         # Unity packages
├── ProjectSettings/  # Unity project configuration
└── README.md
```

Main scene is in `Assets/Scenes`

## Credits

- Tutorial: Valem's "Let's Make a VR Game" series
- YouTube: https://www.youtube.com/@ValemVR
- XR Interaction Toolkit by Unity Technologies

## Want to Help?

If you know how to fix the grab interactions in XR Interaction Toolkit 3.0.8, feel free to fork this and make a pull request. Or just tell me what I did wrong lol.

## License

Do whatever you want with this. It's a learning project. 

Movement and environment work, but grab interactions are broken due to 
XR Interaction Toolkit version differences. First VR project following 
Valem's tutorial series.
