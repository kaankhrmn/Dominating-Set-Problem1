using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominating_Set_Problem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
# include <iostream>

# include<bits/stdc++.h>

			using namespace std;

	vector<vector<int>> graph;
	bool vis[100011];
	int i, j;

	vector<int> solve_dominant(int n, int e)
	{
		vector<int> S;
		for (i = 0; i < n; i++)
		{
			if (!vis[i])
			{
				S.push_back(i);
				vis[i] = true;
				for (j = 0; j < (int)graph[i].size(); j++)
				{
					if (!vis[graph[i][j]])
					{
						vis[graph[i][j]] = true;
						break;
					}
				}
			}
		}
		return S;
	}
	int main()
	{
		int n, e, x, y;
		cout << "Köşe sayısını girin:";
		cin >> n;
		cout << "Kenar sayısını girin:";
		cin >> e;
		graph.resize(n);
		memset(vis, 0, sizeof(vis));
		for (i = 0; i < e; i++)
		{
			cout << "Kenarın uç noktalarını girin " << i + 1 << " : ";
			cin >> x >> y;
			x--; y--;
			graph[x].push_back(y);
			graph[y].push_back(x);
		}
		vector<int> S = solve_dominant(n, e);
		cout << "Gerekli baskın küme aşağıdaki gibidir:\n";
		for (i = 0; i < (int)S.size(); i++)
			cout << S[i] + 1 << " ";
		return 0;
	}





}
	}
}
