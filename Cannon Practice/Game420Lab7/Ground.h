#pragma once
#include "gameobject.h"
class Ground :
	public GameObject
{
public:
	Ground(b2World* world);
	~Ground(void);

	void CreateBox2dObject(float x, float y);
	void Render();
};
